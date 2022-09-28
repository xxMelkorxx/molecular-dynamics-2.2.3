using System;

namespace molecular_dynamics_2_2_3
{
    public partial class AtomicStructure
    {
        /// <summary>
        /// Начальное размещение атомов в ГЦК-решётку.
        /// </summary>
        private void InitPlaсementFcc()
        {
            for (var i = 0; i < Size; i++)
            for (var j = 0; j < Size; j++)
            {
                // Индекс ячейки.
                var idxCell = 2 * (Size * i + j);
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
            for (var i = 0; i < CountAtoms; i++)
                Atoms.Add(new Atom(i, AtomType, new Vector2D(_rnd.NextDouble() * L, _rnd.NextDouble() * L)));
        }
    }
}