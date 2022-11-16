using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace molecular_dynamics_2_2_3
{
    public partial class MainForm : Form
    {
        private AtomicStructure _atomic;
        private Thread _thread;
        private List<List<Vector2D>> _atomsPosition;
        private List<double[]> _speedDistributionList;
		private List<double> _averageSpeedList;
		private double[] _averageSpeedDistribution;
        private double _maxSpeed;
        private int _countdV;
        private int _iter;

        private const double DeltaV = 25;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие создании модели.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCreateModel(object sender, EventArgs e)
        {
            var size = (int)numUpDown_size.Value;
            var countAtoms = (int)numUpDown_countAtoms.Value;
            var temp = (double)numUpDown_temp.Value;
            const int normStep = 200;

            richTextBox_outputWnd.Clear();
            chart_energy.Series[0].Points.Clear();
            chart_energy.Series[1].Points.Clear();
            chart_energy.Series[2].Points.Clear();
            chart_speedDistribution.Series[0].Points.Clear();
            chart_speedDistribution.Series[1].Points.Clear();
            chart_speedDistribution.Series[2].Points.Clear();
            chart_speedDistribution.Series[3].Points.Clear();
            chart_speedDistribution.Series[4].Points.Clear();
            chart_speedDistribution.Series[1].IsVisibleInLegend = false;
            chart_speedDistribution.Series[2].IsVisibleInLegend = false;
            chart_speedDistribution.Series[3].IsVisibleInLegend = false;
            chart_speedDistribution.Series[4].IsVisibleInLegend = false;

            button_stopCalculate.Text = "Остановить";
            button_createModel.Enabled = false;
            button_startCalculate.Enabled = false;
            button_clear.Enabled = false;
            progressBar_calculation.Value = 0;

            Application.DoEvents();

            var task = Task.Factory.StartNew(() =>
            {
                // Инициализация системы.
                if (radioButton_orderlySystem.Checked)
                    _atomic = new AtomicStructure(size);
                else if (radioButton_randomSystem.Checked)
                    _atomic = new AtomicStructure(size, countAtoms);

                // Вычисление начальных параметров системы.
                _atomic.InitCalculation();

                // Приведение скоростей к заданной температуре.
                _atomic.InitVelocityNormalization(temp);
                _atomic.PulseZeroing();

                // Перенормировка скоростей к заданной температуре.
                for (var i = 0; i < normStep; i++)
                {
                    _atomic.Verlet();
                    if (i % 10 == 0)
                    {
                        _atomic.VelocityNormalization(temp);
                        _atomic.PulseZeroing();
                    }
                }

                Application.DoEvents();
            });

            while (!task.IsCompleted)
                Application.DoEvents();

            _iter = 1;

            _maxSpeed = 3 * _atomic.Atoms.Max(atom => atom.Velocity.Magnitude()) * 1e-9;
            _countdV = (int)(_maxSpeed / DeltaV);
			chart_speedDistribution.ChartAreas[0].AxisX.Interval = 4 * DeltaV;

            _speedDistributionList = new List<double[]>();
            _averageSpeedList = new List<double>();
            _speedDistributionList.Add(_atomic.GetSpeedDistribution(_maxSpeed, _countdV, out var averageSpeed));
            _atomsPosition = new List<List<Vector2D>>();
            _atomsPosition.Add(_atomic.AtomsPositions);
            _averageSpeedList.Add(averageSpeed);

            // Вывод начальной информации.
            richTextBox_outputWnd.AppendText(InitInfoSystem());

            button_createModel.Enabled = true;
            button_startCalculate.Enabled = true;
            button_clear.Enabled = true;
            button_saveDistributionSpeed.Enabled = false;

            AlarmBeep(800, 600, 1);
        }

        /// <summary>
        /// Событие запуска вычисления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnStartCalculate(object sender, EventArgs e)
        {
            var countStep = (int)numUpDown_countStep.Value;
            var snapshotStep = (int)numUpDown_snapshotStep.Value;
            var dt = (int)numUpDown_dt.Value;
            var eps = (int)numUpDown_dt_e.Value;
            var isSnapshot = checkBox_isSpapshot.Checked;

            var ke = new List<double> { _atomic.KinEnergy };
            var pe = new List<double> { _atomic.PotEnergy };
            var fe = new List<double> { _atomic.FullEnergy };

            // Определение временного шага.
            _atomic.dt = dt * Math.Pow(10, eps);

            #region -------FormElements-------

            chart_energy.Series[0].Points.Clear();
            chart_energy.Series[1].Points.Clear();
            chart_energy.Series[2].Points.Clear();
            chart_energy.ChartAreas[0].AxisX.Minimum = _iter - 1;
            chart_energy.ChartAreas[0].AxisX.Maximum = _iter + countStep - 1;

            button_startCalculate.Enabled = false;
            button_stopCalculate.Enabled = true;
            button_visualization.Enabled = false;
            button_clear.Enabled = true;
            button_saveDistributionSpeed.Enabled = false;

            progressBar_calculation.Value = 0;
            progressBar_calculation.Maximum = countStep;

            #endregion

            // Вывод начальной информации.
            richTextBox_outputWnd.AppendText("\nЗапуск моделирования...\n");
            richTextBox_outputWnd.AppendText(string.Format("Количество временных шагов: {0}\n", countStep));
            if (isSnapshot)
            {
                richTextBox_outputWnd.AppendText(TableHeader());
                richTextBox_outputWnd.AppendText(TableData(_iter - 1));
            }

            richTextBox_outputWnd.ScrollToCaret();

            progressBar_calculation.PerformStep();

            var sync = SynchronizationContext.Current;
            _thread = new Thread(_ =>
            {
                // Запуск алгоритма Верле.
                for (var i = _iter; i - _iter < countStep; i++)
                {
                    _atomic.Verlet();

                    ke.Add(_atomic.KinEnergy);
                    pe.Add(_atomic.PotEnergy);
                    fe.Add(_atomic.FullEnergy);

                    _atomsPosition.Add(_atomic.AtomsPositions);
                    _speedDistributionList.Add(_atomic.GetSpeedDistribution(_maxSpeed, _countdV, out var averageSpeed));
                    _averageSpeedList.Add(averageSpeed);

                    var idx = i;
                    sync.Send(__ =>
                    {
                        progressBar_calculation.PerformStep();

                        if (isSnapshot)
                        {
                            // Построение графика распределения скоростей.
                            chart_speedDistribution.Series[0].Points.Clear();
                            for (var j = 0; j < _speedDistributionList[idx - _iter].Length; j++)
                                chart_speedDistribution.Series[0].Points.AddXY(j * DeltaV,
                                    _speedDistributionList[idx - _iter][j]);

                            // Вывод данных в RichTextBox.
                            if (idx % snapshotStep == 0 || idx == _iter + countStep - 1)
                            {
                                richTextBox_outputWnd.AppendText(TableData(idx));
                                richTextBox_outputWnd.SelectionStart = richTextBox_outputWnd.Text.Length;
                                richTextBox_outputWnd.ScrollToCaret();
                            }
                        }
                    }, null);
                }

                sync.Send(__ =>
                {
                    richTextBox_outputWnd.AppendText("Конец моделирования...\n");
                    richTextBox_outputWnd.SelectionStart = richTextBox_outputWnd.Text.Length;
                    richTextBox_outputWnd.ScrollToCaret();

                    // Добавление точек на график энергий.
                    for (var i = _iter; i - _iter < fe.Count; i++)
                    {
                        chart_energy.Series[0].Points.AddXY(i, ke[i - _iter]);
                        chart_energy.Series[1].Points.AddXY(i, pe[i - _iter]);
                        chart_energy.Series[2].Points.AddXY(i, fe[i - _iter]);
                    }

                    _iter += countStep;

                    ShowSpeedDistribution();

                    #region -------FormElements-------

                    button_startCalculate.Enabled = true;
                    button_stopCalculate.Enabled = false;
                    button_visualization.Enabled = true;
                    button_saveDistributionSpeed.Enabled = true;

                    #endregion
                }, null);
                AlarmBeep(800, 600, 1);
            })
            {
                IsBackground = true
            };
            _thread.Start();
        }

        /// <summary>
        /// Событие остановки/возобнобления расчёта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        private void OnStopCalculate(object sender, EventArgs e)
        {
            if (_thread != null)
            {
                if (_thread.ThreadState == ThreadState.Background)
                {
                    _thread.Suspend();
                    button_stopCalculate.Text = "Возобновить";
                }
                else if (_thread.ThreadState == (ThreadState.Background | ThreadState.Suspended))
                {
                    _thread.Resume();
                    button_stopCalculate.Text = "Остановить";
                }
            }
            else MessageBox.Show("Поток не запущен!");
        }

        /// <summary>
        /// Событие запуска визуализации.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void OnStartVisualization(object sender, EventArgs e)
        {
            var form = new VisualizationForm(_atomsPosition, _atomic.L);
            form.Show();
        }

        /// <summary>
        /// Событие отображения распределения по скоростям.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickButtonSaveDistributionSpeed(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                RestoreDirectory = true
            };
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                var data = string.Empty;
                for (var i = 0; i < _averageSpeedDistribution.Length; i++)
                    data += string.Format("{0} {1} {2}\n",
                        i * DeltaV,
                        _averageSpeedDistribution[i],
                        AtomicStructure.MaxwellDistribution(i * DeltaV, _atomic.Vsqrt * 1e-9, DeltaV));

                using (var sw = new StreamWriter(saveDialog.OpenFile(), Encoding.Default))
                    sw.Write(data);
            }
        }

        /// <summary>
        /// Событие запуска очистки richTextBox_outputWnd.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClearRichBoxInfo(object sender, EventArgs e)
        {
            richTextBox_outputWnd.Clear();
        }

        /// <summary>
        /// Отображает среднее распределение по скоростям и теоретическое.
        /// </summary>
        private void ShowSpeedDistribution()
        {
			_averageSpeedDistribution = AtomicStructure.AverageSpeedDistribution(_speedDistributionList);

			chart_speedDistribution.Series[0].Points.Clear();
            chart_speedDistribution.Series[1].Points.Clear();
            chart_speedDistribution.Series[2].Points.Clear();
            chart_speedDistribution.Series[3].Points.Clear();
            chart_speedDistribution.Series[4].Points.Clear();
            chart_speedDistribution.Series[1].IsVisibleInLegend = true;
            chart_speedDistribution.Series[2].IsVisibleInLegend = true;
            chart_speedDistribution.Series[3].IsVisibleInLegend = true;
            chart_speedDistribution.Series[4].IsVisibleInLegend = true;

			var averageSpeed = _averageSpeedList.Average();
			var mostLikelySpeed = 0d;
            for (var i = 0; i < _averageSpeedDistribution.Length; i++)
            {
                var v = i * DeltaV;
                mostLikelySpeed += v * _averageSpeedDistribution[i];
                chart_speedDistribution.Series[0].Points.AddXY(v, _averageSpeedDistribution[i]);
                chart_speedDistribution.Series[1].Points
                    .AddXY(v, AtomicStructure.MaxwellDistribution(v, _atomic.Vsqrt * 1e-9, DeltaV));
            }

            chart_speedDistribution.Series[2].Points.AddXY(mostLikelySpeed, _averageSpeedDistribution.Max());
			chart_speedDistribution.Series[3].Points.AddXY(averageSpeed, _averageSpeedDistribution.Max());
			chart_speedDistribution.Series[4].Points.AddXY(_atomic.Vsqrt * 1e-9, _averageSpeedDistribution.Max());

            richTextBox_outputWnd.AppendText("\nСреднеквадратичная скорость: " + (_atomic.Vsqrt * 1e-9).ToString("F3") + " м/с");
            richTextBox_outputWnd.AppendText("\nНаиболее вероятная скорость: " + mostLikelySpeed.ToString("F3") + " м/с");
            richTextBox_outputWnd.AppendText("\nСредняя скорость: " + averageSpeed.ToString("F3") + " м/с");
			richTextBox_outputWnd.SelectionStart = richTextBox_outputWnd.Text.Length;
			richTextBox_outputWnd.ScrollToCaret();
		}

        /// <summary>
        /// Начальная информация о системе.
        /// </summary>
        /// <returns></returns>
        private string InitInfoSystem()
        {
            var text = "Структура создана...\n";
            text += string.Format("Тип атомов - {0}\n", _atomic.AtomType);
            text += string.Format("Размер структуры (Nx/Ny) - {0}/{0}\n", _atomic.Size);
            text += string.Format("Размер структуры (Lx/Ly) - {0}/{0} нм\n", _atomic.L);
            text += string.Format("Число атомов - {0}\n", _atomic.CountAtoms);
            text += string.Format("Параметр решётки - {0} нм\n", _atomic.ParamLat);
            text += string.Format("Кинетическая энергия - {0} эВ\n", _atomic.KinEnergy.ToString("F5"));
            text += string.Format("Потенциальная энергия - {0} эВ\n", _atomic.PotEnergy.ToString("F5"));
            text += string.Format("Полная энергия - {0} эВ\n", _atomic.FullEnergy.ToString("F5"));
            text += string.Format("Температура - {0} К\n", _atomic.Temperature.ToString("F5"));
            return text;
        }

        /// <summary>
        /// Заголовок таблицы.
        /// </summary>
        /// <returns></returns>
        private string TableHeader()
        {
            return string.Format("{0} |{1} |{2} |{3} |{4} |  \n",
                "Шаг".PadLeft(6),
                "Кин. энергия (эВ)".PadLeft(18),
                "Пот. энергия (эВ)".PadLeft(18),
                "Полн. энергия (эВ)".PadLeft(19),
                "Температура (К)".PadLeft(16)
            );
        }

        /// <summary>
        /// Вывод данных в таблицу.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private string TableData(int i)
        {
            return string.Format("{0} |{1} |{2} |{3} |{4} |\n",
                i.ToString().PadLeft(6),
                _atomic.KinEnergy.ToString("F5").PadLeft(18),
                _atomic.PotEnergy.ToString("F5").PadLeft(18),
                _atomic.FullEnergy.ToString("F5").PadLeft(19),
                _atomic.Temperature.ToString("F5").PadLeft(16)
            );
        }

        /// <summary>
        /// Звуковой сигнал.
        /// </summary>
        /// <param name="freq">Частота сигнала.</param>
        /// <param name="duration">Длительность сигнала (мкс).</param>
        /// <param name="count">Повторений.</param>
        private static void AlarmBeep(int freq, int duration, int count)
        {
            for (var i = 0; i < count; i++)
                Console.Beep(freq, duration);
        }
    }
}