using System;

namespace molecular_dynamics_2_2_3
{
	public class PotentialModifiedLJ
	{
		/// <summary>
		/// 1 эВ в Дж с нм.
		/// </summary>
		public const double eV = 0.1602176634;
		/// <summary>
		/// Постоянная Больцмана (эВ/К).
		/// </summary>
		public const double kB = 8.61733262e-5;

		public struct ParamsPotentialModifiedLJ
		{
			/// <summary>
			/// Модуль потенциальной энергии взаимодействия между атомами при равновесии.
			/// </summary>
			public double sigma;
			/// <summary>
			/// Равновесное расстояние между центрами атомов
			/// </summary>
			public double D;

			public double r0, r1, r2;

			public ParamsPotentialModifiedLJ(double D, double sigma)
			{
				this.sigma = sigma; this.D = D;
				r0 = sigma * Math.Pow(2, 1 / 6);
				r1 = 1.2 * r0;
				r2 = 1.8 * r0;
			}
		}

		/// <summary>
		/// Параметры для углерода в модифицированном потенциале Леннарда-Джонса.
		/// </summary>
		public static ParamsPotentialModifiedLJ paramsMLJ_C = new ParamsPotentialModifiedLJ(0.03611, 0.2495);
		/// <summary>
		/// Параметры для азота в модифицированном потенциале Леннарда-Джонса.
		/// </summary>
		public static ParamsPotentialModifiedLJ paramsMLJ_N = new ParamsPotentialModifiedLJ(0.00448, 0.3098);
		/// <summary>
		/// Параметры для аргона в модифицированном потенциале Леннарда-Джонса.
		/// </summary>
		public static ParamsPotentialModifiedLJ paramsMLJ_Ar = new ParamsPotentialModifiedLJ(0.01029, 0.3408);

		/// <summary>
		/// Параметры потенциала.
		/// </summary>
		public ParamsPotentialModifiedLJ param;
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
					case AtomType.C: param = paramsMLJ_C; break;
					case AtomType.N: param = paramsMLJ_N; break;
					case AtomType.Ar: param = paramsMLJ_Ar; break;
				}
			}
		}
		private AtomType _type;

		public PotentialModifiedLJ(AtomType type)
		{
			Type = type;
		}

		/// <summary>
		/// Cила в потенциале Леннарда-Джонса.
		/// </summary>
		/// <param name="r2"></param>
		/// <returns></returns>
		public Vector2D Force(double r, Vector2D dxdy)
		{
			if (r < param.r1) return FLD(r) * dxdy;
			else if (r > param.r2) return Vector2D.Zero;
			else return FLD(r) * K(r) * dxdy + PLD(r) * DK(r);
		}

		/// <summary>
		/// Потенциал Леннарда-Джонса.
		/// </summary>
		/// <param name="r2">Расстояние между частицами.</param>
		/// <returns></returns>
		public double PotentialEnergy(double r)
		{
			if (r < param.r1) return PLD(r);
			else if (r > param.r2) return 0;
			return PLD(r) * K(r);
		}

		private double PLD(double r)
		{
			double ri = param.sigma / r;
			double ri3 = ri * ri * ri;
			double ri6 = ri3 * ri3;
			return 4 * param.D * ri6 * (ri6 - 1);
		}

		private double FLD(double r)
		{
			double ri = param.sigma / r;
			double ri3 = ri * ri * ri;
			double ri6 = ri3 * ri3;
			return 24 * param.D * eV * ri6 * (2 * ri6 - 1) / (r * r);
		}

		private double K(double r)
		{
			return Math.Pow(1 - Math.Pow((r - param.r1) / (param.r1 - param.r2), 2), 2);
		}

		private double DK(double r)
		{
			return 4 * (r - param.r1) / Math.Pow(param.r1 - param.r2, 2) * (1 + Math.Pow((r - param.r1) / (param.r1 - param.r2), 2));
		}
	}
}
