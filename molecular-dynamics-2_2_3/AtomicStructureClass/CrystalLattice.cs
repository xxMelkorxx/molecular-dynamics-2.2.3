using System.Collections.Generic;

namespace molecular_dynamics_2_2_3
{
    public partial class AtomicStructure
    {
        /// <summary>
        /// Начальное размещение атомов в тетрагональную решётку.
        /// </summary>
        private void InitPlaсementFcc()
        {
            for (var i = 0; i < Size; i++)
            for (var j = 0; j < Size; j++)
            {
                // Индекс ячейки.
                var idxCell = Size * i + j;
                Atoms.Add(new Atom(idxCell + 1, AtomType, new Vector2D(i, j) * ParamLat));
            }
        }

        /// <summary>
        /// Начальное размещение атомов случайным образом.
        /// </summary>
        private void InitPlaсementRandom()
        {
            var positions = new List<Vector2D>();
            for (var i = 0; i < Size; i++)
            for (var j = 0; j < Size; j++)
                positions.Add(new Vector2D(i, j) * ParamLat);

            for (var i = 0; i < CountAtoms; i++)
            {
                var idxPos = _rnd.Next(0, positions.Count);
                Atoms.Add(new Atom(i, AtomType, positions[idxPos]));
                positions.RemoveAt(idxPos);
            }
        }
    }
}