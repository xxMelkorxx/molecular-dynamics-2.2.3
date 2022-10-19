using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace molecular_dynamics_2_2_3
{
	public partial class SpeedDistributionForm : Form
	{
		private double[] _speedDistribution;
		private double _deltaV;

		public SpeedDistributionForm(double[] speedDistribution, double maxSpeed, int intervalsSpeed, double v0)
		{
			InitializeComponent();

			_speedDistribution = speedDistribution;
			_deltaV = maxSpeed / intervalsSpeed;
			chart_speedDistribution.Series[0].Points.Clear();
			chart_speedDistribution.Series[1].Points.Clear();
			for (var i = 0; i < speedDistribution.Length; i++)
			{
				var v = i * _deltaV;
				chart_speedDistribution.Series[0].Points.AddXY(v, _speedDistribution[i]);
				//chart_speedDistribution.Series[1].Points.AddXY(v, MaxwellDistribution(v, v0 * 1e-9));
			}
		}

		private void OnClickButtonSaveData(object sender, EventArgs e)
		{
			var saveDialog = new SaveFileDialog
			{
				Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
				RestoreDirectory = true
			};
			if (saveDialog.ShowDialog() == DialogResult.OK)
			{
				var data = string.Empty;
				for (var i = 0; i < _speedDistribution.Length; i++)
					data += string.Format("{0} {1}\n", i * _deltaV, _speedDistribution[i]);

				using (var sw = new StreamWriter(saveDialog.OpenFile(), Encoding.Default))
					sw.Write(data);
			}
		}

		private static double MaxwellDistribution(double v, double v0)
		{
			return 2 * v / (v0 * v0) * Math.Exp(-(v * v) / (v0 * v0));
		}
	}
}
