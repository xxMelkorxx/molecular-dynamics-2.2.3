using System;

namespace molecular_dynamics_2_2_3
{
	public partial class AtomicStructure
	{
		private void InitPlacement()
		{
			switch (AtomType)
			{
				case AtomType.C: InitPlaсementFCC(); break;
				case AtomType.N: InitPlaсementFCC(); break;
				case AtomType.Ar: InitPlaсementFCC(); break;
				case AtomType.Au: InitPlaсementFCC(); break;
			}
		}

		/// <summary>
		/// Начальное размещение атомов в кубическую решётку.
		/// </summary>
		private void InitPlacementSC()
		{
			for (int i = 0; i < Size; i++)
				for (int j = 0; j < Size; j++)
				{
					// Индекс ячейки.
					int idxCell = Size * i + j;
					// ЦК-решётка.
					Atoms.Add(new Atom(idxCell + 1, AtomType, new Vector2D(i, j) * ParamLat));
				}
		}

		/// <summary>
		/// Начальное размещение атомов в ГЦК-решётку.
		/// </summary>
		private void InitPlaсementFCC()
		{
			for (int i = 0; i < Size; i++)
				for (int j = 0; j < Size; j++)
				{
					// Индекс ячейки.
					int idxCell = 2 * (Size * i + j);
					// ГЦК-решётка.
					Atoms.Add(new Atom(idxCell + 1, AtomType, new Vector2D(i, j) * ParamLat));
					Atoms.Add(new Atom(idxCell + 2, AtomType, new Vector2D(i + 0.5, j + 0.5) * ParamLat));
				}
		}

		/// <summary>
		/// Начальное размещение атомов случайным образом.
		/// </summary>
		private void InitPlaсementRandom()
		{
			for (int i = 0; i < N; i++)
				Atoms.Add(new Atom(i, AtomType, new Vector2D(_rnd.NextDouble() * L, _rnd.NextDouble() * L)));
		}
	}
}
