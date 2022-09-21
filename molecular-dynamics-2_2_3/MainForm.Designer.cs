namespace molecular_dynamics_2_2_3
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.pictureBox_visualization = new System.Windows.Forms.PictureBox();
			this.richTextBox_outputWnd = new System.Windows.Forms.RichTextBox();
			this.chart_energy = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button_clear = new System.Windows.Forms.Button();
			this.button_stop = new System.Windows.Forms.Button();
			this.button_start = new System.Windows.Forms.Button();
			this.button_createModel = new System.Windows.Forms.Button();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_visualization)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart_energy)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox_visualization
			// 
			this.pictureBox_visualization.BackColor = System.Drawing.Color.Black;
			this.pictureBox_visualization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_visualization.Location = new System.Drawing.Point(12, 12);
			this.pictureBox_visualization.Name = "pictureBox_visualization";
			this.pictureBox_visualization.Size = new System.Drawing.Size(500, 500);
			this.pictureBox_visualization.TabIndex = 0;
			this.pictureBox_visualization.TabStop = false;
			// 
			// richTextBox_outputWnd
			// 
			this.richTextBox_outputWnd.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.richTextBox_outputWnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox_outputWnd.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBox_outputWnd.Location = new System.Drawing.Point(12, 518);
			this.richTextBox_outputWnd.Name = "richTextBox_outputWnd";
			this.richTextBox_outputWnd.ReadOnly = true;
			this.richTextBox_outputWnd.Size = new System.Drawing.Size(1206, 200);
			this.richTextBox_outputWnd.TabIndex = 1;
			this.richTextBox_outputWnd.Text = "";
			// 
			// chart_energy
			// 
			this.chart_energy.BorderlineColor = System.Drawing.Color.DimGray;
			this.chart_energy.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea1.AxisX.Minimum = 0D;
			chartArea1.AxisX.TitleFont = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea1.AxisY.TitleFont = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea1.Name = "ChartArea1";
			this.chart_energy.ChartAreas.Add(chartArea1);
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
			legend1.DockedToChartArea = "ChartArea1";
			legend1.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			legend1.IsTextAutoFit = false;
			legend1.Name = "Legend1";
			this.chart_energy.Legends.Add(legend1);
			this.chart_energy.Location = new System.Drawing.Point(518, 12);
			this.chart_energy.Name = "chart_energy";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Color = System.Drawing.Color.Red;
			series1.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			series1.Legend = "Legend1";
			series1.LegendText = "Кинетическая энергия";
			series1.Name = "ke";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Color = System.Drawing.Color.Blue;
			series2.Legend = "Legend1";
			series2.LegendText = "Потенциальная энергия";
			series2.Name = "pe";
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series3.Color = System.Drawing.Color.Green;
			series3.Legend = "Legend1";
			series3.LegendText = "Полная энергия";
			series3.Name = "fe";
			this.chart_energy.Series.Add(series1);
			this.chart_energy.Series.Add(series2);
			this.chart_energy.Series.Add(series3);
			this.chart_energy.Size = new System.Drawing.Size(700, 500);
			this.chart_energy.TabIndex = 2;
			this.chart_energy.Text = "Графики энергий";
			// 
			// button_clear
			// 
			this.button_clear.Location = new System.Drawing.Point(918, 727);
			this.button_clear.Name = "button_clear";
			this.button_clear.Size = new System.Drawing.Size(300, 30);
			this.button_clear.TabIndex = 3;
			this.button_clear.Text = "Очистить";
			this.button_clear.UseVisualStyleBackColor = true;
			// 
			// button_stop
			// 
			this.button_stop.Location = new System.Drawing.Point(1225, 727);
			this.button_stop.Name = "button_stop";
			this.button_stop.Size = new System.Drawing.Size(300, 30);
			this.button_stop.TabIndex = 4;
			this.button_stop.Text = "----";
			this.button_stop.UseVisualStyleBackColor = true;
			// 
			// button_start
			// 
			this.button_start.Enabled = false;
			this.button_start.Location = new System.Drawing.Point(1224, 688);
			this.button_start.Name = "button_start";
			this.button_start.Size = new System.Drawing.Size(300, 30);
			this.button_start.TabIndex = 5;
			this.button_start.Text = "Запуск моделирования";
			this.button_start.UseVisualStyleBackColor = true;
			this.button_start.Click += new System.EventHandler(this.OnClickButtonStart);
			// 
			// button_createModel
			// 
			this.button_createModel.Location = new System.Drawing.Point(1225, 649);
			this.button_createModel.Name = "button_createModel";
			this.button_createModel.Size = new System.Drawing.Size(300, 30);
			this.button_createModel.TabIndex = 6;
			this.button_createModel.Text = "Создать модель";
			this.button_createModel.UseVisualStyleBackColor = true;
			this.button_createModel.Click += new System.EventHandler(this.OnClickButtonCreateModel);
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.OnTickTimer);
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 15);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1534, 767);
			this.Controls.Add(this.button_createModel);
			this.Controls.Add(this.button_start);
			this.Controls.Add(this.button_stop);
			this.Controls.Add(this.button_clear);
			this.Controls.Add(this.chart_energy);
			this.Controls.Add(this.richTextBox_outputWnd);
			this.Controls.Add(this.pictureBox_visualization);
			this.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "ИТФИ ННГУ | Исследование распределения по скоростям молекул двумерного идеального" + " газа";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_visualization)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart_energy)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;

		#endregion

		private System.Windows.Forms.PictureBox pictureBox_visualization;
		private System.Windows.Forms.RichTextBox richTextBox_outputWnd;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart_energy;
		private System.Windows.Forms.Button button_clear;
		private System.Windows.Forms.Button button_stop;
		private System.Windows.Forms.Button button_start;
		private System.Windows.Forms.Button button_createModel;
		private System.Windows.Forms.Timer timer;
	}
}

