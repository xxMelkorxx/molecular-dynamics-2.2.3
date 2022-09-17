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
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series40 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series41 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series42 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.pictureBox_visualization = new System.Windows.Forms.PictureBox();
			this.richTextBox_outputWnd = new System.Windows.Forms.RichTextBox();
			this.chart_energy = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button_clear = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button_createModel = new System.Windows.Forms.Button();
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
			chartArea14.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea14.AxisX.Minimum = 0D;
			chartArea14.AxisX.TitleFont = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea14.AxisX2.TitleFont = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea14.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea14.AxisY.TitleFont = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea14.AxisY2.TitleFont = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea14.Name = "ChartArea1";
			this.chart_energy.ChartAreas.Add(chartArea14);
			legend14.BackColor = System.Drawing.Color.Transparent;
			legend14.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
			legend14.DockedToChartArea = "ChartArea1";
			legend14.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			legend14.IsTextAutoFit = false;
			legend14.Name = "Legend1";
			this.chart_energy.Legends.Add(legend14);
			this.chart_energy.Location = new System.Drawing.Point(518, 12);
			this.chart_energy.Name = "chart_energy";
			series40.ChartArea = "ChartArea1";
			series40.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series40.Color = System.Drawing.Color.Red;
			series40.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			series40.Legend = "Legend1";
			series40.LegendText = "Кинетическая энергия";
			series40.Name = "ke";
			series41.ChartArea = "ChartArea1";
			series41.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series41.Color = System.Drawing.Color.Blue;
			series41.Legend = "Legend1";
			series41.LegendText = "Потенциальная энергия";
			series41.Name = "pe";
			series42.ChartArea = "ChartArea1";
			series42.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series42.Color = System.Drawing.Color.Green;
			series42.Legend = "Legend1";
			series42.LegendText = "Полная энергия";
			series42.Name = "fe";
			this.chart_energy.Series.Add(series40);
			this.chart_energy.Series.Add(series41);
			this.chart_energy.Series.Add(series42);
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1225, 727);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(300, 30);
			this.button1.TabIndex = 4;
			this.button1.Text = "Очистить";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1224, 688);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(300, 30);
			this.button2.TabIndex = 5;
			this.button2.Text = "Очистить";
			this.button2.UseVisualStyleBackColor = true;
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1534, 767);
			this.Controls.Add(this.button_createModel);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button_clear);
			this.Controls.Add(this.chart_energy);
			this.Controls.Add(this.richTextBox_outputWnd);
			this.Controls.Add(this.pictureBox_visualization);
			this.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "ИТФИ ННГУ | Исследование распределения по скоростям молекул двумерного идеального" +
    " газа";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_visualization)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart_energy)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox_visualization;
		private System.Windows.Forms.RichTextBox richTextBox_outputWnd;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart_energy;
		private System.Windows.Forms.Button button_clear;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button_createModel;
	}
}

