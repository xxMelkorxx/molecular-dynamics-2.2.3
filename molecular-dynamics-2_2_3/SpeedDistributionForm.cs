using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace molecular_dynamics_2_2_3
{
	public partial class SpeedDistributionForm : Form
	{
		private double[] _speedDistribution;

		public SpeedDistributionForm(double[] speedDistribution)
		{
			InitializeComponent();

			_speedDistribution = speedDistribution;
			chart_speedDistribution.Series[0].Points.Clear();
			for (var i = 0; i < speedDistribution.Length; i++)
				chart_speedDistribution.Series[0].Points.AddXY(i, _speedDistribution[i]);
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
					data += string.Format("{0} {1}\n", i, _speedDistribution[i]);

				using (var sw = new StreamWriter(saveDialog.OpenFile(), Encoding.Default))
					sw.Write(data);
			}
		}
	}
}
