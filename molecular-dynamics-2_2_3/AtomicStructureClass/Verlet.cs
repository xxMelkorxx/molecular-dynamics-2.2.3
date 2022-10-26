using System;

namespace molecular_dynamics_2_2_3
{
    public partial class AtomicStructure
    {
        /// <summary>
        /// Вычисление начальных параметров системы (Acceleration, Pe, Ke, Press).
        /// </summary>
        public void InitCalculation()
        {
            _ke = 0;
            _pe = 0;
            
            Accel();
            
            // Вычисление кинетической энергии.
            Atoms.ForEach(atom => _ke += 0.5 * atom.Velocity.SquaredMagnitude() * atom.Weight);
        }

        /// <summary>
        /// Алгоритм Верле.
        /// </summary>
        public void Verlet()
        {
            _ke = 0;
            _pe = 0;

            // Вычисление новых координат.
            Atoms.ForEach(atom =>
            {
                var newPos = atom.Velocity * dt + 0.5 * atom.Acceleration * dt * dt;
                // Изменение координат с учётом периодических граничных условий.
                atom.Position = Periodic(atom.Position + newPos);
            });

            // Частичное изменение скорости, используя старое ускорение.
            Atoms.ForEach(atom => atom.Velocity += 0.5 * atom.Acceleration * dt);

            // Вычисление нового ускорения.
            Accel();

            Atoms.ForEach(atom =>
            {
                // Частичное изменение скорости, используя новое ускорение.
                atom.Velocity += 0.5 * atom.Acceleration * dt;
                // Вычисление кинетической энергии.
                _ke += 0.5 * atom.Velocity.SquaredMagnitude() * atom.Weight;
            });
        }

        /// <summary>
        /// Вычисление ускорения, pe, virial.
        /// </summary>
        private void Accel()
        {
            Atoms.ForEach(atom => atom.Acceleration = Vector2D.Zero);

            for (var i = 0; i < CountAtoms - 1; i++)
            {
                var atomI = Atoms[i];
                var sumForce = Vector2D.Zero;
                for (var j = i + 1; j < CountAtoms; j++)
                {
                    var atomJ = Atoms[j];

                    // Расстояние между частицами.
                    var rij = Separation(atomI.Position, atomJ.Position, out var dxdy);

                    var force = _potential.Force(rij, dxdy);
                    sumForce += force;
                    atomI.Acceleration += force / atomI.Weight;
                    atomJ.Acceleration -= force / atomJ.Weight;
                    _pe += _potential.PotentialEnergy(rij);
                }
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
        /// Учёт периодических граничных условий.
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        private Vector2D Periodic(Vector2D pos)
        {
            var newPos = Vector2D.Zero;

            if (pos.X > L) newPos.X = pos.X - L;
            else if (pos.X < 0) newPos.X = L + pos.X;
            else newPos.X = pos.X;

            if (pos.Y > L) newPos.Y = pos.Y - L;
            else if (pos.Y < 0) newPos.Y = L + pos.Y;
            else newPos.Y = pos.Y;

            return newPos;
        }
    }
}