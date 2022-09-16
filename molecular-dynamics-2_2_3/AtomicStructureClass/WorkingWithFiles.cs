using System;
using System.IO;
using System.Text;

namespace MMD
{
	public partial class AtomicStructure
	{
		/// <summary>
		/// Снимок системы с выводом данных в файл .csv.
		/// </summary>
		/// <param name="idxStep"></param>
		public void Snapshot(int idxStep, int r = 5)
		{
			var pathSnapshot = Environment.CurrentDirectory + "\\Data\\Snapshots\\Snapshot." + idxStep + ".txt";
			var strL = L.ToString().Replace(',', '.');
			var text = "ITEM: TIMESTEP\n" + idxStep;
			text += "\nITEM: NUMBER OF ATOMS\n" + N;
			text += "\nITEM: BOX BOUNDS pp pp pp\n" + 0 + " " + strL + "\n" + 0 + " " + strL + "\n" + 0 + " " + strL;
			text += "\nITEM: ATOMS ID Type X Y Z NPX NPY NPZ\n";
			foreach (var atom in Atoms)
			{
				text += string.Format("{0} {1} {2} {3} {4} {5} {6} {7}\n",
							atom.ID,
							atom.Type,
							Math.Round(atom.Position.X, r).ToString().Replace(',', '.'),
							Math.Round(atom.Position.Y, r).ToString().Replace(',', '.'),
							Math.Round(atom.Position.Z, r).ToString().Replace(',', '.'),
							Math.Round(atom.PositionNonePeriodic.X, r).ToString().Replace(',', '.'),
							Math.Round(atom.PositionNonePeriodic.Y, r).ToString().Replace(',', '.'),
							Math.Round(atom.PositionNonePeriodic.Z, r).ToString().Replace(',', '.')
						);
			}
			File.WriteAllText(pathSnapshot, text);
		}

		/// <summary>
		/// Запись данных о системе в файл.
		/// </summary>
		/// <returns></returns>
		public void DataToSaveToAFile(Stream stream)
		{
			var data = string.Empty;
			data += string.Format("{0}:", Size);
			data += string.Format("{0}:", ParamLat);
			data += string.Format("{0}:", (int)AtomType);
			data += string.Format("{0}:d", (int)PotentialType);
			foreach (var atom in Atoms)
			{
				data += string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12}a",
							atom.ID,
							atom.Position.X,
							atom.Position.Y,
							atom.Position.Z,
							atom.PositionNonePeriodic.X,
							atom.PositionNonePeriodic.Y,
							atom.PositionNonePeriodic.Z,
							atom.Velocity.X,
							atom.Velocity.Y,
							atom.Velocity.Z,
							atom.Acceleration.X,
							atom.Acceleration.Y,
							atom.Acceleration.Z
							);
			}
			data += "d";

			using (var sw = new StreamWriter(stream, Encoding.Default))
				sw.Write(data);
		}

		/// <summary>
		/// Загрузка системы из файла.
		/// </summary>
		/// <param name="data">Данные файла.</param>
		/// <returns></returns>
		public static AtomicStructure LoadingData(Stream stream)
		{
			string data = string.Empty;
			using (var sr = new StreamReader(stream, Encoding.Default))
				data = sr.ReadToEnd();
			var dataSplit = data.Split('d');

			// Считывание параметров структуры.
			var paramAtomic = dataSplit[0].Split(':');
			AtomicStructure atomicStructure = new AtomicStructure(
				Convert.ToInt32(paramAtomic[0]),
				Convert.ToDouble(paramAtomic[1]),
				(AtomType)Convert.ToInt32(paramAtomic[2]),
				(PotentialType)Convert.ToInt32(paramAtomic[3]));

			// Считывание данных об атомах.
			var paramAtoms = dataSplit[1].Split('a');
			for (int i = 0; i < atomicStructure.N; i++)
			{
				var paramAtom = paramAtoms[i].Split(' ');
				int id = Convert.ToInt32(paramAtom[0]);
				Vector pos = new Vector(Convert.ToDouble(paramAtom[1]), Convert.ToDouble(paramAtom[2]), Convert.ToDouble(paramAtom[3]));
				Vector posNP = new Vector(Convert.ToDouble(paramAtom[4]), Convert.ToDouble(paramAtom[5]), Convert.ToDouble(paramAtom[6]));
				Vector vel = new Vector(Convert.ToDouble(paramAtom[7]), Convert.ToDouble(paramAtom[8]), Convert.ToDouble(paramAtom[9]));
				Vector accel = new Vector(Convert.ToDouble(paramAtom[10]), Convert.ToDouble(paramAtom[11]), Convert.ToDouble(paramAtom[12]));
				atomicStructure.Atoms.Add(new Atom(id, atomicStructure.AtomType, pos)
				{
					PositionNonePeriodic = posNP,
					Velocity = vel,
					Acceleration = accel
				});
			}

			// Вычисление начальных параметров системы.
			atomicStructure.InitCalculation();
			return atomicStructure;
		}
	}
}
