using System;

namespace molecular_dynamics_2_2_3
{
	public class PotentialModifiedLJ
	{
		/// <summary>
		/// 1 эВ в Дж с нм.
		/// </summary>
		private const double eV = 0.1602176634;
		/// <summary>
		/// Постоянная Больцмана (эВ/К).
		/// </summary>
		private const double kB = 8.61733262e-5;

		public struct ParamsPotentialModifiedLJ
		{
			/// <summary>
			/// Модуль потенциальной энергии взаимодействия между атомами при равновесии.
			/// </summary>
			public double Sigma;
			/// <summary>
			/// Равновесное расстояние между центрами атомов
			/// </summary>
			public double R0, R1, R2;
			/// <summary>
			/// Модуль потенциальной энергии взаимодействия между атомами при равновесии.
			/// </summary>
			public double D;

			public ParamsPotentialModifiedLJ(double d, double sigma)
			{
				Sigma = sigma; D = d;
				R0 = sigma * Math.Pow(2, 1.0 / 6.0);
				R1 = 1.2 * R0;
				R2 = 1.8 * R0;
			}
		}

		/// <summary>
		/// Параметры для углерода в модифицированном потенциале Леннарда-Джонса.
		/// </summary>
		public static ParamsPotentialModifiedLJ ParamsMLJ_C = new ParamsPotentialModifiedLJ(0.03611, 0.2495);
		/// <summary>
		/// Параметры для азота в модифицированном потенциале Леннарда-Джонса.
		/// </summary>
		public static ParamsPotentialModifiedLJ ParamsMLJ_N = new ParamsPotentialModifiedLJ(0.00448, 0.3098);
		/// <summary>
		/// Параметры для аргона в модифицированном потенциале Леннарда-Джонса.
		/// </summary>
		public static ParamsPotentialModifiedLJ ParamsMLJ_Ar = new ParamsPotentialModifiedLJ(0.01029, 0.3408);

		/// <summary>
		/// Параметры потенциала.
		/// </summary>
		public ParamsPotentialModifiedLJ Param;
		/// <summary>
		/// Тип атома.
		/// </summary>
		public AtomType Type
		{
			get { return _type; }
			set
			{
				_type = value;
				switch (_type)
				{
					case AtomType.C: Param = ParamsMLJ_C; break;
					case AtomType.N: Param = ParamsMLJ_N; break;
					case AtomType.Ar: Param = ParamsMLJ_Ar; break;
					default: Param = ParamsMLJ_Ar; break;
				}
			}
		}
		private AtomType _type;

		public PotentialModifiedLJ(AtomType type)
		{
			Type = type;
		}

		/// <summary>
		/// Вычисление силы.
		/// </summary>
		/// <param name="r"></param>
		/// <param name="dxdy"></param>
		/// <returns></returns>
		public Vector2D Force(double r, Vector2D dxdy)
		{
			return r < Param.R1 ? FLD(r) * dxdy : r > Param.R2 ? Vector2D.Zero : K(r) * Vector2D.One; 
		}

		/// <summary>
		/// Вычисление потенциала.
		/// </summary>
		/// <param name="r">Расстояние между частицами.</param>
		/// <returns></returns>
		public double PotentialEnergy(double r)
		{
			return r < Param.R1 ? PLD(r) : r > Param.R2 ? 0 : PLD(r) * K(r);
		}
		
		/// <summary>
		/// Потенциал Леннарда-Джонса.
		/// </summary>
		/// <param name="r">Расстояние между частицами.</param>
		/// <returns></returns>
		private double PLD(double r)
		{
			var ri = Param.Sigma / r;
			var ri3 = ri * ri * ri;
			var ri6 = ri3 * ri3;
			return 4 * Param.D * ri6 * (ri6 - 1);
		}

		/// <summary>
		/// Cила в потенциале Леннарда-Джонса.
		/// </summary>
		/// <param name="r">Расстояние между частицами.</param>
		/// <returns></returns>
		private double FLD(double r)
		{
			var ri = Param.Sigma / r;
			var ri3 = ri * ri * ri;
			var ri6 = ri3 * ri3;
			return 24 * Param.D * eV * ri6 * (2 * ri6 - 1) / (r * r);
		}

		/// <summary>
		/// Функция обрезания потенциала.
		/// </summary>
		/// <param name="r">Расстояние между частицами.</param>
		/// <returns></returns>
		private double K(double r)
		{
			return Math.Pow(1 - Math.Pow((r - Param.R1) / (Param.R1 - Param.R2), 2), 2);
		}
	}
}
