using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
		private AtomType atomType;
		private int _iter;

		public MainForm()
		{
			InitializeComponent();
		}

		private void OnClickButtonCreateModel(object sender, EventArgs e)
		{
			richTextBox_outputWnd.Clear();
			
			atomType = AtomType.Ar;
			int size = 10;
			double displacement = 0.001;
			bool isDisplacement = false;

			_atomic = new AtomicStructure(size, atomType);
			_drawing = new Drawing(pictureBox_visualization, 0, 0, _atomic.L, _atomic.L);
			_drawing.Clear();

			if (isDisplacement)
			{
				_atomic.AtomsDisplacement(displacement);
				_atomic.InitCalculation();
			}

			_drawing.DrawAtoms(Color.White, _atomic.Atoms, _atomic.L);

			richTextBox_outputWnd.Text += InitInfoSystem();

		}

		/// <summary>
		/// Начальная информация о системе.
		/// </summary>
		/// <returns></returns>
		private string InitInfoSystem()
		{
			string text = "Структура создана...\n";
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
		private void AlarmBeep(int freq, int duration, int count)
		{
			for (int i = 0; i < count; i++)
				Console.Beep(freq, duration);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}
	}
}
