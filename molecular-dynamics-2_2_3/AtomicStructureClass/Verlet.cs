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
            _virial = 0;
            
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
            _virial = 0;

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

                    // Вычисление расстояния между частицами.
                    var rij = Separation(atomI.Position, atomJ.Position, out var dxdy);

                    var force = potential.Force(rij, dxdy);
                    sumForce += force;
                    atomI.Acceleration += force / atomI.Weight;
                    atomJ.Acceleration -= force / atomJ.Weight;
                    _pe += potential.PotentialEnergy(rij);
                }

                // Для вычисления давления.
                _virial += atomI.Position.X * sumForce.X + atomI.Position.Y * sumForce.Y;
            }
        }
    }
}