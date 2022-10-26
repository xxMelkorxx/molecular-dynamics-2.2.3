namespace molecular_dynamics_2_2_3
{
	partial class SpeedDistributionForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart_speedDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button_saveData = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.chart_speedDistribution)).BeginInit();
			this.SuspendLayout();
			// 
			// chart_speedDistribution
			// 
			this.chart_speedDistribution.BorderlineColor = System.Drawing.Color.DimGray;
			this.chart_speedDistribution.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea2.AxisX.Interval = 100D;
			chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea2.AxisX.Minimum = 0D;
			chartArea2.AxisX.Title = "Скорость атомов, м/с";
			chartArea2.AxisX.TitleFont = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea2.AxisX2.TitleFont = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea2.AxisY.Minimum = 0D;
			chartArea2.AxisY.Title = "Отн. среднее число атомов";
			chartArea2.AxisY.TitleFont = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea2.AxisY2.TitleFont = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea2.Name = "ChartArea1";
			this.chart_speedDistribution.ChartAreas.Add(chartArea2);
			legend2.Alignment = System.Drawing.StringAlignment.Far;
			legend2.BackColor = System.Drawing.Color.Transparent;
			legend2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
			legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
			legend2.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			legend2.IsTextAutoFit = false;
			legend2.Name = "Legend1";
			legend2.TextWrapThreshold = 50;
			this.chart_speedDistribution.Legends.Add(legend2);
			this.chart_speedDistribution.Location = new System.Drawing.Point(14, 13);
			this.chart_speedDistribution.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.chart_speedDistribution.Name = "chart_speedDistribution";
			series3.ChartArea = "ChartArea1";
			series3.Color = System.Drawing.Color.Blue;
			series3.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			series3.Legend = "Legend1";
			series3.LegendText = "Распеределение по скоростям (среднее)";
			series3.Name = "speedDistribution";
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series4.Color = System.Drawing.Color.Red;
			series4.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			series4.Legend = "Legend1";
			series4.Name = "maxwellDistribution";
			this.chart_speedDistribution.Series.Add(series3);
			this.chart_speedDistribution.Series.Add(series4);
			this.chart_speedDistribution.Size = new System.Drawing.Size(897, 369);
			this.chart_speedDistribution.TabIndex = 9;
			this.chart_speedDistribution.Text = "Распределение по скоростям";
			// 
			// button_saveData
			// 
			this.button_saveData.Location = new System.Drawing.Point(612, 388);
			this.button_saveData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button_saveData.Name = "button_saveData";
			this.button_saveData.Size = new System.Drawing.Size(300, 30);
			this.button_saveData.TabIndex = 10;
			this.button_saveData.Text = "Сохранить данные в файл";
			this.button_saveData.UseVisualStyleBackColor = true;
			this.button_saveData.Click += new System.EventHandler(this.OnClickButtonSaveData);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(260, 393);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(315, 22);
			this.textBox1.TabIndex = 11;
			// 
			// SpeedDistributionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(925, 427);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button_saveData);
			this.Controls.Add(this.chart_speedDistribution);
			this.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "SpeedDistributionForm";
			this.Text = "Распределение по скоростям (среднее)";
			((System.ComponentModel.ISupportInitialize)(this.chart_speedDistribution)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart_speedDistribution;
		private System.Windows.Forms.Button button_saveData;
		private System.Windows.Forms.TextBox textBox1;
	}
}