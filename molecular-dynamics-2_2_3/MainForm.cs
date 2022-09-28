using System;
using System.Collections.Generic;
using System.Drawing;
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
        private List<Atom>[] _atomsPosition;
        private int _iter;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnCreateModel(object sender, EventArgs e)
        {
            var size = (int)numUpDown_size.Value;
            var countAtoms = (int)numUpDown_countAtoms.Value;
            var velocityAtoms = (double)numUpDown_velocitySystem.Value;
            var temp = (double)numUpDown_temp.Value;

            _atomic = new AtomicStructure(size, countAtoms);

            _atomic.InitVelocityNormalization(temp);
            _atomic.PulseZeroing();
            _iter = 0;

            // Вывод начальной информации.
            richTextBox_outputWnd.Clear();
            richTextBox_outputWnd.AppendText(InitInfoSystem());

            button_startCalculate.Enabled = true;
        }

        private void OnStartCalculate(object sender, EventArgs e)
        {
            var countStep = (int)numUpDown_countStep.Value;
            var snapshotStep = (int)numUpDown_snapshotStep.Value;
            var dt = (int)numUpDown_dt.Value;
            var eps = (int)numUpDown_dt_e.Value;

            // Определение временного шага.
            _atomic.dt = dt * Math.Pow(10, eps);

            #region -------FormElements-------

            button_startCalculate.Enabled = false;
            button_stopCalculate.Enabled = true;
            button_clear.Enabled = true;
            chart_energy.Series[0].Points.Clear();
            chart_energy.Series[1].Points.Clear();
            chart_energy.Series[2].Points.Clear();
            chart_energy.ChartAreas[0].AxisX.Minimum = _iter - 1;
            chart_energy.ChartAreas[0].AxisX.Maximum = _iter + countStep - 1;
            // progressBar_Calculation.Value = 0;
            // progressBar_Calculation.Maximum = countStep;
            // progressBar_Calculation.PerformStep();

            #endregion

            // Добавление на график начальных значений энергий.
            var ke = new List<double> { _atomic.KinEnergy };
            var pe = new List<double> { _atomic.PotEnergy };
            var fe = new List<double> { _atomic.FullEnergy };

            // Вывод начальной информации.
            richTextBox_outputWnd.AppendText("\nЗапуск моделирования...\n");
            richTextBox_outputWnd.AppendText(string.Format("Число временных шагов: {0}:\n", countStep));
            richTextBox_outputWnd.AppendText(TableHeader());
            richTextBox_outputWnd.AppendText(TableData(_iter - 1));

            // Запуск алгоритма Верле.
            _atomsPosition = new List<Atom>[countStep];
            for (var i = _iter; i - _iter < countStep; i++)
            {
                _atomic.Verlet();

                ke.Add(_atomic.KinEnergy);
                pe.Add(_atomic.PotEnergy);
                fe.Add(_atomic.FullEnergy);

                if (i % snapshotStep == 0 || i == _iter + countStep - 1)
                {
                    richTextBox_outputWnd.AppendText(TableData(i));
                    richTextBox_outputWnd.SelectionStart = richTextBox_outputWnd.Text.Length;
                    richTextBox_outputWnd.ScrollToCaret();
                }
            }

            richTextBox_outputWnd.AppendText("Конец моделирования...\n");
            richTextBox_outputWnd.SelectionStart = richTextBox_outputWnd.Text.Length;
            richTextBox_outputWnd.ScrollToCaret();

            AlarmBeep(800, 600, 1);

            // Добавление точек на график энергий.
            for (var i = _iter; i - _iter < fe.Count; i++)
            {
                chart_energy.Series[0].Points.AddXY(i, ke[i - _iter]);
                chart_energy.Series[1].Points.AddXY(i, pe[i - _iter]);
                chart_energy.Series[2].Points.AddXY(i, fe[i - _iter]);
            }

            _iter += countStep;

            #region -------FormElements-------

            button_startCalculate.Enabled = true;
            button_stopCalculate.Enabled = false;
            button_visualization.Enabled = true;

            #endregion

            // var sync = SynchronizationContext.Current;
            // _thread = new Thread(_ =>
            // {
            //     for (var i = _iter; i - _iter < countStep; i++)
            //     {
            //         _atomic.Verlet();
            //
            //         sync.Send(__ =>
            //         {
            //             // progressBar_Calculation.PerformStep();
            //
            //             // Вывод данных в RichTextBox.
            //             if (i % snapshotStep == 0 || i == _iter + countStep - 1)
            //             {
            //                 richTextBox_outputWnd.AppendText(TableData(i));
            //                 richTextBox_outputWnd.SelectionStart = richTextBox_outputWnd.Text.Length;
            //                 richTextBox_outputWnd.ScrollToCaret();
            //             }
            //             
            //         }, null);
            //
            //         ke.Add(_atomic.KinEnergy);
            //         pe.Add(_atomic.PotEnergy);
            //         fe.Add(_atomic.FullEnergy);
            //     }
            //
            //     sync.Send(__ =>
            //     {
            //         richTextBox_outputWnd.AppendText("Конец моделирования...\n");
            //         richTextBox_outputWnd.SelectionStart = richTextBox_outputWnd.Text.Length;
            //         richTextBox_outputWnd.ScrollToCaret();
            //
            //         // Добавление точек на график энергий.
            //         for (int i = _iter; i - _iter < fe.Count; i++)
            //         {
            //             chart_energy.Series[0].Points.AddXY(i, ke[i - _iter]);
            //             chart_energy.Series[1].Points.AddXY(i, pe[i - _iter]);
            //             chart_energy.Series[2].Points.AddXY(i, fe[i - _iter]);
            //         }
            //
            //         _iter += countStep;
            //
            //         #region -------FormElements-------
            //
            //         button_startCalculate.Enabled = true;
            //         button_stopCalculate.Enabled = false;
            //
            //         #endregion
            //     }, null);
            //     AlarmBeep(800, 600, 1);
            // });
            // _thread.IsBackground = true;
            // _thread.Start();
        }

        private void OnStartVisualization(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
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
            text += string.Format("Объём - {0} нм³\n", _atomic.Volume.ToString("F5"));
            text += string.Format("Давление - {0} бар\n", _atomic.Press.ToString("F0"));
            return text;
        }

        /// <summary>
        /// Заголовок таблицы.
        /// </summary>
        /// <returns></returns>
        private string TableHeader()
        {
            return string.Format("{0} |{1} |{2} |{3} |{4} |{5} |{6}  |\n",
                "Шаг".PadLeft(6),
                "Кин. энергия (эВ)".PadLeft(18),
                "Пот. энергия (эВ)".PadLeft(18),
                "Полн. энергия (эВ)".PadLeft(19),
                "Температура (К)".PadLeft(16),
                "Объём (нм²)".PadLeft(12),
                "Давление (бар)".PadLeft(14)
            );
        }

        /// <summary>
        /// Вывод данных в таблицу.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private string TableData(int i)
        {
            return string.Format("{0} |{1} |{2} |{3} |{4} |{5} |{6}  |\n",
                i.ToString().PadLeft(6),
                _atomic.KinEnergy.ToString("F5").PadLeft(18),
                _atomic.PotEnergy.ToString("F5").PadLeft(18),
                _atomic.FullEnergy.ToString("F5").PadLeft(19),
                _atomic.Temperature.ToString("F5").PadLeft(16),
                _atomic.Volume.ToString("F5").PadLeft(12),
                _atomic.Press.ToString("F0").PadLeft(14)
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