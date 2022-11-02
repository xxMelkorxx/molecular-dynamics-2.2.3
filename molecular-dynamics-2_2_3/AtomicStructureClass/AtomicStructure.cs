using System;
using System.Linq;
using System.Collections.Generic;

namespace molecular_dynamics_2_2_3
{
    public partial class AtomicStructure
    {
        #region -----------Свойства-----------

        /// <summary>
        /// Список атомов расчётной ячейки.
        /// </summary>
        public List<Atom> Atoms { get; }

        // Параметры системы.
        /// <summary>
        /// Размер расчётной ячейки.
        /// </summary>
        public int Size { get; }

        /// <summary>
        /// Параметр решётки (нм).
        /// </summary>
        public double ParamLat { get; set; }

        /// <summary>
        /// Размер расчётной ячейки (нм).
        /// </summary>
        public double L => ParamLat * Size;

        /// <summary>
        /// Число атомов.
        /// </summary>
        public int CountAtoms { set; get; }

        // Характеристики системы.
        /// <summary>
        /// Кинетическая энергия системы (эВ).
        /// </summary>
        public double KinEnergy => _ke / eV;

        private double _ke;

        /// <summary>
        /// Потенциальная энергия системы (эВ).
        /// </summary>
        public double PotEnergy => _pe;

        private double _pe;

        /// <summary>
        /// Полная энергия системы (эВ).
        /// </summary>
        public double FullEnergy => PotEnergy + KinEnergy;

        /// <summary>
        /// Температура системы.
        /// </summary>
        public double Temperature => 2.0 / 3.0 * KinEnergy / (kB / eV * CountAtoms);

        /// <summary>
        /// Тип атомов.
        /// </summary>
        public AtomType AtomType
        {
            get => _atomType;
            set
            {
                _atomType = value;
                switch (_atomType)
                {
                    case AtomType.Ar:
                        ParamLat = 0.526;
                        break;
                    default:
                        ParamLat = 0.526;
                        break;
                }
            }
        }

        private AtomType _atomType;

        #endregion

        public double Vsqrt;

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
        private readonly PotentialMlj _potential;

        /// <summary>
        /// Список текущего положения атомов.
        /// </summary>
        public List<Vector2D> AtomsPositions
        {
            get
            {
                _atomsPositions = new List<Vector2D>();
                Atoms.ForEach(atom => _atomsPositions.Add(atom.Position));
                return _atomsPositions;
            }
        }

        private List<Vector2D> _atomsPositions;

        /// <summary>
        /// Инициализация и создание упорядоченной атомной структуры.
        /// </summary>
        /// <param name="size">Размер расчётной ячейки</param>
        /// <param name="atomType"></param>
        public AtomicStructure(int size, AtomType atomType = AtomType.Ar)
        {
            _rnd = new Random(DateTime.Now.Millisecond);
            _potential = new PotentialMlj(atomType);
            Atoms = new List<Atom>();

            Size = size;
            CountAtoms = size * size;
            AtomType = atomType;

            // Начальное размещение атомов.
            InitPlaсementFcc();
        }

        /// <summary>
        /// Инициализация и создание случайной атомной структуры.
        /// </summary>
        /// <param name="size">Размер расчётной ячейки</param>
        /// <param name="countAtoms">Число атомов.</param>
        /// <param name="atomType">Тип атомов.</param>
        public AtomicStructure(int size, int countAtoms, AtomType atomType = AtomType.Ar)
        {
            _rnd = new Random(DateTime.Now.Millisecond);
            _potential = new PotentialMlj(atomType);
            Atoms = new List<Atom>();

            Size = size;
            CountAtoms = countAtoms;
            AtomType = atomType;

            // Начальное размещение атомов.
            InitPlaсementRandom();
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
                Atoms.ForEach(atom => sum += atom.Velocity);
                sum /= CountAtoms;

                if (Math.Abs(sum.X + sum.Y) > eps)
                    Atoms.ForEach(atom => atom.Velocity -= sum);
                else break;
            }
        }

        /// <summary>
        /// Начальное смещение атомов.
        /// </summary>
        /// <param name="k">Коэффициент смещения.</param>
        public void AtomsDisplacement(double k)
        {
            Atoms.ForEach(atom =>
            {
                var displacement = (-1 * Vector2D.One + 2 * new Vector2D(_rnd.NextDouble(), _rnd.NextDouble())) * k *
                                   ParamLat;
                atom.Position = Periodic(atom.Position + displacement);
            });
        }

        /// <summary>
        /// Начальная перенормировка скоростей.
        /// </summary>
        /// <param name="T"></param>
        public void InitVelocityNormalization(double T)
        {
            Vsqrt = Math.Sqrt(2 * kB * T / Atoms[0].Weight);
            const double pi2 = 2 * Math.PI;
            Atoms.ForEach(atom =>
                atom.Velocity = new Vector2D(Math.Sin(pi2 * _rnd.NextDouble()), Math.Cos(pi2 * _rnd.NextDouble())) *
                                Vsqrt);
        }

        /// <summary>
        /// Перенормировка скоростей к заданной температуре.
        /// </summary>
        public void VelocityNormalization(double T)
        {
            var sum = Atoms.Sum(atom => atom.Weight * atom.Velocity.SquaredMagnitude());
            var beta = Math.Sqrt(3 * CountAtoms * kB * T / sum);
            Atoms.ForEach(atom => atom.Velocity *= beta);
        }

        /// <summary>
        /// Распределение атомов по скоростям.
        /// </summary>
        /// <param name="maxSpeed"></param>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public double[] GetSpeedDistribution(double maxSpeed, int intervals = 50)
        {
            var atomsVelocities = new List<double>();
            Atoms.ForEach(atom => atomsVelocities.Add(atom.Velocity.Magnitude() * 1e-9));

            var deltaSpeed = maxSpeed / intervals;

            var speedDistribution = new double[intervals];
            atomsVelocities.ForEach(vel =>
            {
                var i = (int)(vel / deltaSpeed);
                speedDistribution[i >= speedDistribution.Length ? speedDistribution.Length - 1 : i] += 1.0 / CountAtoms;
            });

            return speedDistribution;
        }

        /// <summary>
        /// Рассчёт среднего распределения по скоростям.
        /// </summary>
        /// <param name="speedDistributionList"></param>
        /// <returns></returns>
        public static double[] AverageSpeedDistribution(List<double[]> speedDistributionList)
        {
            var length = speedDistributionList[0].Length;
            var result = new double[length];

            for (var i = 0; i < length; i++)
            {
                var average = 0.0;
                for (var j = 0; j < speedDistributionList.Count; j++)
                    average += speedDistributionList[j][i];

                result[i] = average / speedDistributionList.Count;
            }

            return result;
        }

        public static double MaxwellDistribution(double v, double v0, double dV)
        {
            return 2 * v * dV / (v0 * v0) * Math.Exp(-(v * v) / (v0 * v0));
        }
    }
}