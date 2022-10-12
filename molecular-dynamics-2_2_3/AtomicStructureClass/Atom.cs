namespace molecular_dynamics_2_2_3
{
    public enum AtomType
    {
        Ar
    }

    public class Atom
    {
        /// <summary>
        /// ID атома.
        /// </summary>
        public int Id { get; set; }

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
                        Weight = 39.948 * 1.66054e-27;
                        break;
                    default:
                        Weight = 39.948 * 1.66054e-27;
                        break;
                }
            }
        }

        private AtomType _type;

        /// <summary>
        /// Координаты атома.
        /// </summary>
        public Vector2D Position { get; set; }

        /// <summary>
        /// Скорость атома.
        /// </summary>
        public Vector2D Velocity { get; set; }

        /// <summary>
        /// Ускорение атома.
        /// </summary>
        public Vector2D Acceleration { get; set; }

        /// <summary>
        /// Масса атома (кг).
        /// </summary>
        public double Weight { get; private set; }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// Создание атома.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="pos"></param>
        public Atom(int id, AtomType type, Vector2D pos)
        {
            Id = id;
            Type = type;
            Position = pos;
            Velocity = Vector2D.Zero;
            Acceleration = Vector2D.Zero;
        }
    }
}