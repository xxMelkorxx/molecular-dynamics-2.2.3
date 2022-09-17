using System;
using System.Collections.Generic;

namespace molecular_dynamics_2_2_3
{
	public partial class AtomicStructure
	{
		#region -----------Свойства-----------
		/// <summary>
		/// Список атомов расчётной ячейки.
		/// </summary>
		public List<Atom> Atoms { get; set; }

		// Параметры системы.
		/// <summary>
		/// Размер расчётной ячейки.
		/// </summary>
		public int Size { get; set; }

		/// <summary>
		/// Параметр решётки (нм).
		/// </summary>
		public double ParamLat { get; set; }

		/// <summary>
		/// Размер расчётной ячейки (нм).
		/// </summary>
		public double L
		{
			get { return ParamLat * Size; }
		}

		/// <summary>
		/// Число атомов.
		/// </summary>
		public int N
		{
			get { return Atoms.Count; }
		}

		// Характеристики системы.
		/// <summary>
		/// Кинетическая энергия системы (эВ).
		/// </summary>
		public double KinEnergy
		{
			get { return _ke / eV; }
		}
		private double _ke;

		/// <summary>
		/// Потенциальная энергия системы (эВ).
		/// </summary>
		public double PotEnergy
		{
			get { return _pe; }
		}
		private double _pe;

		/// <summary>
		/// Полная энергия системы (эВ).
		/// </summary>
		public double FullEnergy
		{
			get { return PotEnergy + KinEnergy; }
		}

		/// <summary>
		/// Температура системы.
		/// </summary>
		public double Temperature
		{
			get { return 2.0 / 3.0 * KinEnergy / (kB / eV * N); }
		}
		/// <summary>
		/// Давление системы.
		/// </summary>
		public double Press
		{
			get { return (KinEnergy + 0.5 * _virial / N) / Volume * 1e4; }
		}
		private double _virial;

		/// <summary>
		/// Объём системы.
		/// </summary>
		public double Volume
		{
			get { return L * L; }
		}

		/// <summary>
		/// Тип атомов.
		/// </summary>
		public AtomType AtomType
		{
			get { return _atomType; }
			set
			{
				_atomType = value;
				switch (_atomType)
				{
					case AtomType.C: ParamLat = 0.3567; break;
					case AtomType.N: ParamLat = 0.5661; break;
					case AtomType.Ar: ParamLat = 0.526; break;
					case AtomType.Au: ParamLat = 0.40781; break;
				}
			}
		}
		private AtomType _atomType;
		#endregion

		// Параметры симуляции.
		/// <summary>
		/// Величина временного шага.
		/// </summary>
		public double dt;

		// Константы.
		/// <summary>
		/// 1 эВ в Дж с нм.
		/// </summary>
		private const double eV = 0.1602176634;
		/// <summary>
		/// Постоянная Больцмана (Дж/К с нм).
		/// </summary>
		private const double kB = 1.380649e-5;

		/// <summary>
		/// Генератор случайных чисел.
		/// </summary>
		private readonly Random _rnd;

		/// <summary>
		/// Класс потенциала.
		/// </summary>
		private readonly PotentialModifiedLJ _potential;

		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public AtomicStructure(int size, double paramLat, AtomType atomType)
		{
			_rnd = new Random(DateTime.Now.Millisecond);
			_potential = new PotentialModifiedLJ(atomType);
			Atoms = new List<Atom>();
			AtomType = atomType;
			Size = size;
			ParamLat = paramLat;
		}

		/// <summary>
		/// Инициализация и создание атомной структуры.
		/// </summary>
		/// <param name="size"></param>
		/// <param name="atomType"></param>
		/// <param name="potentialType"></param>
		/// <param name="vmax"></param>
		/// <param name="coefСircum"></param>
		public AtomicStructure(int size, AtomType atomType)
		{
			_rnd = new Random(DateTime.Now.Millisecond);
			_potential = new PotentialModifiedLJ(atomType);
			Atoms = new List<Atom>();

			Size = size;
			AtomType = atomType;

			// Начальное размещение атомов.
			InitPlacement();

			// Вычисление начальных параметров системы.
			InitCalculation();
		}

		/// <summary>
		/// Зануление импульса системы.
		/// </summary>
		/// <param name="eps">Точность.</param>
		public void PulseZeroing(double eps = 1e-5)
		{
			Vector2D sum;
			while (true)
			{
				sum = Vector2D.Zero;
				foreach (var atom in Atoms)
					sum += atom.Velocity;
				sum /= N;

				if (Math.Abs(sum.X + sum.Y) > eps)
					foreach (var atom in Atoms)
						atom.Velocity -= sum;
				else break;
			}
		}

		/// <summary>
		/// Начальное смещение атомов.
		/// </summary>
		/// <param name="k">Коэффициент смещения.</param>
		public void AtomsDisplacement(double k)
		{
			foreach (var atom in Atoms)
			{
				Vector2D displacement = (-1 * Vector2D.One + 2 * new Vector2D(_rnd.NextDouble(), _rnd.NextDouble())) * k * ParamLat;
				atom.Position = Periodic(atom.Position + displacement);
			}
		}

		/// <summary>
		/// Вычисление расстояния между частицами с учётом периодических граничных условий. 
		/// </summary>
		/// <param name="vec1"></param>
		/// <param name="vec2"></param>
		/// <param name="dxdy"></param>
		/// <returns></returns>
		private double Separation(Vector2D vec1, Vector2D vec2, out Vector2D dxdy)
		{
			dxdy = vec1 - vec2;

			// Обеспечивает, что расстояние между частицами никогда не будет больше L/2.
			if (Math.Abs(dxdy.X) > 0.5 * L)
				dxdy.X -= Math.Sign(dxdy.X) * L;
			if (Math.Abs(dxdy.Y) > 0.5 * L)
				dxdy.Y -= Math.Sign(dxdy.Y) * L;

			return dxdy.Magnitude();
		}

		/// <summary>
		/// Вычисление квадрата расстояния между частицами с учётом периодических граничных условий. 
		/// </summary>
		/// <param name="vec1"></param>
		/// <param name="vec2"></param>
		/// <param name="dxdy"></param>
		/// <returns></returns>
		private double SeparationSqured(Vector2D vec1, Vector2D vec2, out Vector2D dxdy)
		{
			dxdy = vec1 - vec2;

			// Обеспечивает, что расстояние между частицами никогда не будет больше L/2.
			if (Math.Abs(dxdy.X) > 0.5 * L)
				dxdy.X -= Math.Sign(dxdy.X) * L;
			if (Math.Abs(dxdy.Y) > 0.5 * L)
				dxdy.Y -= Math.Sign(dxdy.Y) * L;

			return dxdy.SquaredMagnitude();
		}

		/// <summary>
		/// Учёт периодических граничных условий.
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		private Vector2D Periodic(Vector2D pos)
		{
			Vector2D newPos = Vector2D.Zero;

			if (pos.X > L) newPos.X = pos.X - L;
			else if (pos.X < 0) newPos.X = L + pos.X;
			else newPos.X = pos.X;

			if (pos.Y > L) newPos.Y = pos.Y - L;
			else if (pos.Y < 0) newPos.Y = L + pos.Y;
			else newPos.Y = pos.Y;

			return newPos;
		}

		/// <summary>
		/// Начальная перенормировка скоростей.
		/// </summary>
		/// <param name="T"></param>
		public void InitVelocityNormalization(double T)
		{
			double Vsqrt = Math.Sqrt(3 * kB * T / Atoms[0].Weight);
			foreach (var atom in Atoms)
			{
				double pi2 = 2 * Math.PI;
				atom.Velocity = new Vector2D(Math.Sin(pi2 * _rnd.NextDouble()), Math.Cos(pi2 * _rnd.NextDouble())) * Vsqrt;
				atom.Velocity = (-1 * Vector2D.One + 2 * new Vector2D(_rnd.NextDouble(), _rnd.NextDouble())) * Vsqrt;
			}
		}

		/// <summary>
		/// Перенормировка скоростей к заданной температуре.
		/// </summary>
		public void VelocityNormalization(int T)
		{
			double sum = 0;
			foreach (var atom in Atoms)
				sum += atom.Weight * atom.Velocity.SquaredMagnitude();
			double beta = Math.Sqrt(3 * N * kB * T / sum);
			foreach (var atom in Atoms)
				atom.Velocity *= beta;
		}

		/// <summary>
		/// Средний квадрат смещения.
		/// </summary>
		/// <param name="rt1"></param>
		/// <param name="rt2"></param>
		/// <returns></returns>
		public double AverageSquareOffset(List<Vector2D> rt1, List<Vector2D> rt2)
		{
			double sum = 0;
			for (int i = 0; i < rt1.Count; i++)
				sum += (rt2[i] - rt1[i]).SquaredMagnitude();
			return sum / N;
		}
	}
}