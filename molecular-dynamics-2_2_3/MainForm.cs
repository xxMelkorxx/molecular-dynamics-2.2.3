using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace molecular_dynamics_2_2_3
{
	public partial class MainForm : Form
	{
		private Drawing _drawing;
		private AtomicStructure _atomic;
		private AtomType _atomType;
		private int _iter;
		private List<double> _ke, _pe, _fe;
		private double _dt;

		public MainForm()
		{
			InitializeComponent();
		}

		private void OnClickButtonCreateModel(object sender, EventArgs e)
		{
			richTextBox_outputWnd.Clear();

			const int size = 10;
			const double displacement = 0.001;
			const double temp = 300;
			const bool isDisplacement = false;

			_atomType = AtomType.Ar;
			//_atomic = new AtomicStructure(size, AtomType.Ar);
			_atomic = new AtomicStructure(size, 100, _atomType);

			_drawing = new Drawing(pictureBox_visualization, 0, 0, _atomic.L, _atomic.L);
			
			if (isDisplacement)
			{
				_atomic.AtomsDisplacement(displacement);
				_atomic.InitCalculation();
			}

			_drawing.DrawAtoms(Color.White, _atomic.Atoms, _atomic.L);

			//_atomic.InitVelocityNormalization(temp);
			//_atomic.PulseZeroing();
			_iter = 0;

			// Вывод начальной информации.
			richTextBox_outputWnd.AppendText(InitInfoSystem());

			button_start.Enabled = true;
		}

		private void OnClickButtonStart(object sender, EventArgs e)
		{
			if (button_start.Text == "Запуск моделирования")
			{
				_atomic.dt = 1e-15;
				//_ke = new List<double> { _atomic.KinEnergy };
				//_pe = new List<double> { _atomic.PotEnergy };
				//_fe = new List<double> { _atomic.FullEnergy };
				_iter++;

				// Вывод начальной информации.
				richTextBox_outputWnd.AppendText("\nЗапуск моделирования...\n");
				richTextBox_outputWnd.AppendText(TableHeader());
				richTextBox_outputWnd.AppendText(TableData(_iter));

				button_start.Text = "Остановить";
				timer.Start();
			}
			else if (button_start.Text == "Остановить")
			{
				richTextBox_outputWnd.AppendText("Моделирование остановлено...");

				button_start.Text = "Запуск моделирования";
				timer.Stop();
			}
		}

		private void OnTickTimer(object sender, EventArgs e)
		{
			_atomic.Verlet();
			_iter++;

			richTextBox_outputWnd.AppendText(TableData(_iter));
			richTextBox_outputWnd.SelectionStart = richTextBox_outputWnd.Text.Length;
			richTextBox_outputWnd.ScrollToCaret();

			_drawing.DrawAtoms(Color.White, _atomic.Atoms, _atomic.L);
			Application.DoEvents();
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
			text += string.Format("Число атомов - {0}\n", _atomic.N);
			text += string.Format("Параметр решётки - {0} нм\n", _atomic.ParamLat);
			text += string.Format("Кинетическая энергия - {0} эВ\n", Math.Round(_atomic.KinEnergy, 5));
			text += string.Format("Потенциальная энергия - {0} эВ\n", Math.Round(_atomic.PotEnergy, 5));
			text += string.Format("Полная энергия - {0} эВ\n", Math.Round(_atomic.FullEnergy, 5));
			text += string.Format("Температура - {0} К\n", Math.Round(_atomic.Temperature, 5));
			text += string.Format("Объём - {0} нм³\n", Math.Round(_atomic.Volume, 5));
			text += string.Format("Давление - {0} бар\n", Math.Round(_atomic.Press, 0));
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
				Math.Round(_atomic.KinEnergy, 5).ToString().PadLeft(18),
				Math.Round(_atomic.PotEnergy, 5).ToString().PadLeft(18),
				Math.Round(_atomic.FullEnergy, 5).ToString().PadLeft(19),
				Math.Round(_atomic.Temperature, 5).ToString().PadLeft(16),
				Math.Round(_atomic.Volume, 5).ToString().PadLeft(12),
				Math.Round(_atomic.Press, 0).ToString().PadLeft(14)
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
