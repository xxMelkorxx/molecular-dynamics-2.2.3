using System;

namespace molecular_dynamics_2_2_3
{
    public class PotentialMlj
    {
        /// <summary>
        /// 1 эВ в Дж с нм.
        /// </summary>
        private const double eV = 0.1602176634;

        /// <summary>
        /// Постоянная Больцмана (эВ/К).
        /// </summary>
        private const double kB = 8.61733262e-5;

        public struct ParamsPotentialMlj
        {
            /// <summary>
            /// Модуль потенциальной энергии взаимодействия между атомами при равновесии.
            /// </summary>
            public double Sigma;

            /// <summary>
            /// Равновесное расстояние между центрами атомов
            /// </summary>
            public double R0;
            
            /// <summary>
            /// Радиусы обрезания потенциала.
            /// </summary>
            public double R1, R2;

            /// <summary>
            /// Модуль потенциальной энергии взаимодействия между атомами при равновесии.
            /// </summary>
            public double D;

            public ParamsPotentialMlj(double d, double sigma)
            {
                Sigma = sigma;
                D = d;
                R0 = sigma * Math.Pow(2, 1.0 / 6.0);
                R1 = 1.2 * R0;
                R2 = 1.8 * R0;
            }
        }

        /// <summary>
        /// Параметры для аргона в модифицированном потенциале Леннарда-Джонса.
        /// </summary>
        public static ParamsPotentialMlj ParamsMljAr = new ParamsPotentialMlj(0.01029, 0.3408);

        /// <summary>
        /// Параметры потенциала.
        /// </summary>
        public ParamsPotentialMlj Param;

        /// <summary>
        /// Тип атома.
        /// </summary>
        public AtomType Type
        {
            get => _type;
            set
            {
                _type = value;
                switch (_type)
                {
                    case AtomType.Ar:
                        Param = ParamsMljAr;
                        break;
                    default:
                        Param = ParamsMljAr;
                        break;
                }
            }
        }

        private AtomType _type;

        public PotentialMlj(AtomType type)
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
            return (r < Param.R1) ? FLD(r) * dxdy : ((r > Param.R2) ? Vector2D.Zero : K(r) * Vector2D.One);
        }

        /// <summary>
        /// Вычисление потенциала.
        /// </summary>
        /// <param name="r">Расстояние между частицами.</param>
        /// <returns></returns>
        public double PotentialEnergy(double r)
        {
            return (r < Param.R1) ? PLD(r) : ((r > Param.R2) ? 0 : PLD(r) * K(r));
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
            return Math.Pow(1 - (r - Param.R1) * (r - Param.R1) / (Param.R1 - Param.R2) / (Param.R1 - Param.R2), 2);
        }
    }
}