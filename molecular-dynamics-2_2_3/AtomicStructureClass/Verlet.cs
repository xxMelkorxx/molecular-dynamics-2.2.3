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
			_ke = 0; _pe = 0; _virial = 0;
			Accel();
			// Вычисление кинетической энергии.
			foreach (var atom in Atoms)
				_ke += 0.5 * atom.Velocity.SquaredMagnitude() * atom.Weight;
		}

		/// <summary>
		/// Алгоритм Верле.
		/// </summary>
		public void Verlet()
		{
			_ke = 0; _pe = 0; _virial = 0;

			// Изменение координат с учётом периодических граничных условий.
			foreach (var atom in Atoms)
			{
				Vector2D newPos = atom.Velocity * dt + 0.5 * atom.Acceleration * dt * dt;
				atom.Position = Periodic(atom.Position + newPos);
			}

			// Частичное изменение скорости, используя старое ускорение.
			foreach (var atom in Atoms)
				atom.Velocity += 0.5 * atom.Acceleration * dt;

			// Вычисление нового ускорения.
			Accel();

			foreach (var atom in Atoms)
			{
				// Частичное изменение скорости, используя новое ускорение.
				atom.Velocity += 0.5 * atom.Acceleration * dt;
				// Вычисление кинетической энергии.
				_ke += 0.5 * atom.Velocity.SquaredMagnitude() * atom.Weight;
			}
		}

		/// <summary>
		/// Вычисление ускорения, pe, virial.
		/// </summary>
		private void Accel()
		{
			foreach (var atom in Atoms)
				atom.Acceleration = Vector2D.Zero;
			for (int i = 0; i < N - 1; i++)
			{
				Atom atomI = Atoms[i];

				Vector2D sumForce = Vector2D.Zero;
				for (int j = i + 1; j < N; j++)
				{
					Atom atomJ = Atoms[j];

					// Вычисление расстояния между частицами.
					double rij = Separation(atomI.Position, atomJ.Position, out Vector2D dxdy);

					Vector2D force = _potential.Force(rij, dxdy);
					sumForce += force;
					atomI.Acceleration += force / atomI.Weight;
					atomJ.Acceleration -= force / atomJ.Weight;
					_pe += _potential.PotentialEnergy(rij);
				}

				// Для вычисления давления.
				_virial += atomI.Position.X * sumForce.X + atomI.Position.Y * sumForce.Y;
			}
		}
	}
}
