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
			System.Windows.Forms.GroupBox groupBox_paramSystem;
			System.Windows.Forms.Label label_temp;
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label_velocitySystem;
			System.Windows.Forms.Label label_countAtoms;
			System.Windows.Forms.GroupBox groupBox_paramSimulation;
			System.Windows.Forms.Label label_dt;
			System.Windows.Forms.Label label_e;
			System.Windows.Forms.Label label_snapshotStep;
			System.Windows.Forms.Label label_countStep;
			System.Windows.Forms.GroupBox groupBox_info;
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.numUpDown_temp = new System.Windows.Forms.NumericUpDown();
			this.numUpDown_size = new System.Windows.Forms.NumericUpDown();
			this.numUpDown_velocitySystem = new System.Windows.Forms.NumericUpDown();
			this.numUpDown_countAtoms = new System.Windows.Forms.NumericUpDown();
			this.numUpDown_dt = new System.Windows.Forms.NumericUpDown();
			this.numUpDown_dt_e = new System.Windows.Forms.NumericUpDown();
			this.numUpDown_snapshotStep = new System.Windows.Forms.NumericUpDown();
			this.numUpDown_countStep = new System.Windows.Forms.NumericUpDown();
			this.chart_energy = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.richTextBox_outputWnd = new System.Windows.Forms.RichTextBox();
			this.button_clear = new System.Windows.Forms.Button();
			this.button_stopCalculate = new System.Windows.Forms.Button();
			this.button_startCalculate = new System.Windows.Forms.Button();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.button_createModel = new System.Windows.Forms.Button();
			this.button_visualization = new System.Windows.Forms.Button();
			groupBox_paramSystem = new System.Windows.Forms.GroupBox();
			label_temp = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label_velocitySystem = new System.Windows.Forms.Label();
			label_countAtoms = new System.Windows.Forms.Label();
			groupBox_paramSimulation = new System.Windows.Forms.GroupBox();
			label_dt = new System.Windows.Forms.Label();
			label_e = new System.Windows.Forms.Label();
			label_snapshotStep = new System.Windows.Forms.Label();
			label_countStep = new System.Windows.Forms.Label();
			groupBox_info = new System.Windows.Forms.GroupBox();
			groupBox_paramSystem.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_temp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_size)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_velocitySystem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_countAtoms)).BeginInit();
			groupBox_paramSimulation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_dt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_dt_e)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_snapshotStep)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_countStep)).BeginInit();
			groupBox_info.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart_energy)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox_paramSystem
			// 
			groupBox_paramSystem.Controls.Add(this.numUpDown_temp);
			groupBox_paramSystem.Controls.Add(label_temp);
			groupBox_paramSystem.Controls.Add(this.numUpDown_size);
			groupBox_paramSystem.Controls.Add(label1);
			groupBox_paramSystem.Controls.Add(this.numUpDown_velocitySystem);
			groupBox_paramSystem.Controls.Add(label_velocitySystem);
			groupBox_paramSystem.Controls.Add(this.numUpDown_countAtoms);
			groupBox_paramSystem.Controls.Add(label_countAtoms);
			groupBox_paramSystem.Location = new System.Drawing.Point(797, 12);
			groupBox_paramSystem.Name = "groupBox_paramSystem";
			groupBox_paramSystem.Size = new System.Drawing.Size(300, 140);
			groupBox_paramSystem.TabIndex = 8;
			groupBox_paramSystem.TabStop = false;
			groupBox_paramSystem.Text = "Параметры системы";
			// 
			// numUpDown_temp
			// 
			this.numUpDown_temp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numUpDown_temp.Increment = new decimal(new int[] { 10, 0, 0, 0 });
			this.numUpDown_temp.Location = new System.Drawing.Point(219, 105);
			this.numUpDown_temp.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			this.numUpDown_temp.Name = "numUpDown_temp";
			this.numUpDown_temp.Size = new System.Drawing.Size(75, 22);
			this.numUpDown_temp.TabIndex = 12;
			this.numUpDown_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUpDown_temp.Value = new decimal(new int[] { 100, 0, 0, 0 });
			// 
			// label_temp
			// 
			label_temp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_temp.Location = new System.Drawing.Point(6, 107);
			label_temp.Name = "label_temp";
			label_temp.Size = new System.Drawing.Size(211, 18);
			label_temp.TabIndex = 13;
			label_temp.Text = "Начальная температура:";
			label_temp.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// numUpDown_size
			// 
			this.numUpDown_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numUpDown_size.Location = new System.Drawing.Point(219, 21);
			this.numUpDown_size.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			this.numUpDown_size.Name = "numUpDown_size";
			this.numUpDown_size.Size = new System.Drawing.Size(75, 22);
			this.numUpDown_size.TabIndex = 10;
			this.numUpDown_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUpDown_size.Value = new decimal(new int[] { 10, 0, 0, 0 });
			// 
			// label1
			// 
			label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label1.Location = new System.Drawing.Point(6, 23);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(209, 18);
			label1.TabIndex = 11;
			label1.Text = "Размер расчётной ячейки:";
			label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// numUpDown_velocitySystem
			// 
			this.numUpDown_velocitySystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numUpDown_velocitySystem.Increment = new decimal(new int[] { 100, 0, 0, 0 });
			this.numUpDown_velocitySystem.Location = new System.Drawing.Point(219, 77);
			this.numUpDown_velocitySystem.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			this.numUpDown_velocitySystem.Name = "numUpDown_velocitySystem";
			this.numUpDown_velocitySystem.Size = new System.Drawing.Size(75, 22);
			this.numUpDown_velocitySystem.TabIndex = 8;
			this.numUpDown_velocitySystem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label_velocitySystem
			// 
			label_velocitySystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_velocitySystem.Location = new System.Drawing.Point(6, 79);
			label_velocitySystem.Name = "label_velocitySystem";
			label_velocitySystem.Size = new System.Drawing.Size(211, 18);
			label_velocitySystem.TabIndex = 9;
			label_velocitySystem.Text = "Начальная скорость:";
			label_velocitySystem.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// numUpDown_countAtoms
			// 
			this.numUpDown_countAtoms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numUpDown_countAtoms.Increment = new decimal(new int[] { 10, 0, 0, 0 });
			this.numUpDown_countAtoms.Location = new System.Drawing.Point(219, 49);
			this.numUpDown_countAtoms.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
			this.numUpDown_countAtoms.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
			this.numUpDown_countAtoms.Name = "numUpDown_countAtoms";
			this.numUpDown_countAtoms.Size = new System.Drawing.Size(75, 22);
			this.numUpDown_countAtoms.TabIndex = 6;
			this.numUpDown_countAtoms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUpDown_countAtoms.Value = new decimal(new int[] { 50, 0, 0, 0 });
			// 
			// label_countAtoms
			// 
			label_countAtoms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_countAtoms.Location = new System.Drawing.Point(6, 51);
			label_countAtoms.Name = "label_countAtoms";
			label_countAtoms.Size = new System.Drawing.Size(209, 18);
			label_countAtoms.TabIndex = 7;
			label_countAtoms.Text = "Число атомов:";
			label_countAtoms.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// groupBox_paramSimulation
			// 
			groupBox_paramSimulation.Controls.Add(label_dt);
			groupBox_paramSimulation.Controls.Add(label_e);
			groupBox_paramSimulation.Controls.Add(this.numUpDown_dt);
			groupBox_paramSimulation.Controls.Add(this.numUpDown_dt_e);
			groupBox_paramSimulation.Controls.Add(label_snapshotStep);
			groupBox_paramSimulation.Controls.Add(this.numUpDown_snapshotStep);
			groupBox_paramSimulation.Controls.Add(label_countStep);
			groupBox_paramSimulation.Controls.Add(this.numUpDown_countStep);
			groupBox_paramSimulation.Location = new System.Drawing.Point(797, 158);
			groupBox_paramSimulation.Name = "groupBox_paramSimulation";
			groupBox_paramSimulation.Size = new System.Drawing.Size(300, 108);
			groupBox_paramSimulation.TabIndex = 9;
			groupBox_paramSimulation.TabStop = false;
			groupBox_paramSimulation.Text = "Параметры моделирования";
			// 
			// label_dt
			// 
			label_dt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_dt.AutoSize = true;
			label_dt.Location = new System.Drawing.Point(72, 23);
			label_dt.Name = "label_dt";
			label_dt.Size = new System.Drawing.Size(105, 14);
			label_dt.TabIndex = 36;
			label_dt.Text = "Временной шаг:";
			label_dt.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label_e
			// 
			label_e.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_e.AutoSize = true;
			label_e.Location = new System.Drawing.Point(229, 23);
			label_e.Name = "label_e";
			label_e.Size = new System.Drawing.Size(14, 14);
			label_e.TabIndex = 35;
			label_e.Text = "e";
			// 
			// numUpDown_dt
			// 
			this.numUpDown_dt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numUpDown_dt.Location = new System.Drawing.Point(183, 21);
			this.numUpDown_dt.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
			this.numUpDown_dt.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			this.numUpDown_dt.Name = "numUpDown_dt";
			this.numUpDown_dt.Size = new System.Drawing.Size(40, 22);
			this.numUpDown_dt.TabIndex = 34;
			this.numUpDown_dt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUpDown_dt.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// numUpDown_dt_e
			// 
			this.numUpDown_dt_e.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numUpDown_dt_e.Location = new System.Drawing.Point(249, 21);
			this.numUpDown_dt_e.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
			this.numUpDown_dt_e.Minimum = new decimal(new int[] { 100, 0, 0, -2147483648 });
			this.numUpDown_dt_e.Name = "numUpDown_dt_e";
			this.numUpDown_dt_e.Size = new System.Drawing.Size(45, 22);
			this.numUpDown_dt_e.TabIndex = 33;
			this.numUpDown_dt_e.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUpDown_dt_e.Value = new decimal(new int[] { 14, 0, 0, -2147483648 });
			// 
			// label_snapshotStep
			// 
			label_snapshotStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_snapshotStep.AutoSize = true;
			label_snapshotStep.Location = new System.Drawing.Point(38, 79);
			label_snapshotStep.Name = "label_snapshotStep";
			label_snapshotStep.Size = new System.Drawing.Size(175, 14);
			label_snapshotStep.TabIndex = 32;
			label_snapshotStep.Text = "Частота снимков системы:";
			label_snapshotStep.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// numUpDown_snapshotStep
			// 
			this.numUpDown_snapshotStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numUpDown_snapshotStep.Location = new System.Drawing.Point(219, 77);
			this.numUpDown_snapshotStep.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			this.numUpDown_snapshotStep.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			this.numUpDown_snapshotStep.Name = "numUpDown_snapshotStep";
			this.numUpDown_snapshotStep.Size = new System.Drawing.Size(75, 22);
			this.numUpDown_snapshotStep.TabIndex = 31;
			this.numUpDown_snapshotStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUpDown_snapshotStep.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// label_countStep
			// 
			label_countStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_countStep.AutoSize = true;
			label_countStep.Location = new System.Drawing.Point(52, 51);
			label_countStep.Name = "label_countStep";
			label_countStep.Size = new System.Drawing.Size(161, 14);
			label_countStep.TabIndex = 30;
			label_countStep.Text = "Число временных шагов:";
			label_countStep.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// numUpDown_countStep
			// 
			this.numUpDown_countStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numUpDown_countStep.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
			this.numUpDown_countStep.Location = new System.Drawing.Point(219, 49);
			this.numUpDown_countStep.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
			this.numUpDown_countStep.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			this.numUpDown_countStep.Name = "numUpDown_countStep";
			this.numUpDown_countStep.Size = new System.Drawing.Size(75, 22);
			this.numUpDown_countStep.TabIndex = 29;
			this.numUpDown_countStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUpDown_countStep.Value = new decimal(new int[] { 1000, 0, 0, 0 });
			// 
			// groupBox_info
			// 
			groupBox_info.Controls.Add(this.chart_energy);
			groupBox_info.Controls.Add(this.richTextBox_outputWnd);
			groupBox_info.Location = new System.Drawing.Point(12, 12);
			groupBox_info.Name = "groupBox_info";
			groupBox_info.Size = new System.Drawing.Size(779, 519);
			groupBox_info.TabIndex = 11;
			groupBox_info.TabStop = false;
			groupBox_info.Text = "Инфографика";
			// 
			// chart_energy
			// 
			this.chart_energy.BorderlineColor = System.Drawing.Color.DimGray;
			this.chart_energy.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea1.AxisX.Minimum = 0D;
			chartArea1.AxisX.Title = "Энергия (эВ)";
			chartArea1.AxisX.TitleFont = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea1.AxisY.Title = "Временной шаг";
			chartArea1.AxisY.TitleFont = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea1.Name = "ChartArea1";
			this.chart_energy.ChartAreas.Add(chartArea1);
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
			legend1.DockedToChartArea = "ChartArea1";
			legend1.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			legend1.IsTextAutoFit = false;
			legend1.Name = "Legend1";
			this.chart_energy.Legends.Add(legend1);
			this.chart_energy.Location = new System.Drawing.Point(6, 21);
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
			this.chart_energy.Size = new System.Drawing.Size(767, 275);
			this.chart_energy.TabIndex = 2;
			this.chart_energy.Text = "Графики энергий";
			// 
			// richTextBox_outputWnd
			// 
			this.richTextBox_outputWnd.Location = new System.Drawing.Point(6, 302);
			this.richTextBox_outputWnd.Name = "richTextBox_outputWnd";
			this.richTextBox_outputWnd.Size = new System.Drawing.Size(767, 211);
			this.richTextBox_outputWnd.TabIndex = 7;
			this.richTextBox_outputWnd.Text = "";
			// 
			// button_clear
			// 
			this.button_clear.Enabled = false;
			this.button_clear.Location = new System.Drawing.Point(641, 537);
			this.button_clear.Name = "button_clear";
			this.button_clear.Size = new System.Drawing.Size(150, 25);
			this.button_clear.TabIndex = 3;
			this.button_clear.Text = "Очистить";
			this.button_clear.UseVisualStyleBackColor = true;
			// 
			// button_stopCalculate
			// 
			this.button_stopCalculate.Enabled = false;
			this.button_stopCalculate.Location = new System.Drawing.Point(797, 506);
			this.button_stopCalculate.Name = "button_stopCalculate";
			this.button_stopCalculate.Size = new System.Drawing.Size(300, 25);
			this.button_stopCalculate.TabIndex = 4;
			this.button_stopCalculate.Text = "Остановить";
			this.button_stopCalculate.UseVisualStyleBackColor = true;
			// 
			// button_startCalculate
			// 
			this.button_startCalculate.Enabled = false;
			this.button_startCalculate.Location = new System.Drawing.Point(797, 475);
			this.button_startCalculate.Name = "button_startCalculate";
			this.button_startCalculate.Size = new System.Drawing.Size(300, 25);
			this.button_startCalculate.TabIndex = 5;
			this.button_startCalculate.Text = "Запуск моделирования";
			this.button_startCalculate.UseVisualStyleBackColor = true;
			this.button_startCalculate.Click += new System.EventHandler(this.OnStartCalculate);
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 15);
			// 
			// button_createModel
			// 
			this.button_createModel.Location = new System.Drawing.Point(797, 444);
			this.button_createModel.Name = "button_createModel";
			this.button_createModel.Size = new System.Drawing.Size(300, 25);
			this.button_createModel.TabIndex = 6;
			this.button_createModel.Text = "Создать модель";
			this.button_createModel.UseVisualStyleBackColor = true;
			this.button_createModel.Click += new System.EventHandler(this.OnCreateModel);
			// 
			// button_visualization
			// 
			this.button_visualization.Enabled = false;
			this.button_visualization.Location = new System.Drawing.Point(797, 537);
			this.button_visualization.Name = "button_visualization";
			this.button_visualization.Size = new System.Drawing.Size(300, 25);
			this.button_visualization.TabIndex = 10;
			this.button_visualization.Text = "Запуск моделирования";
			this.button_visualization.UseVisualStyleBackColor = true;
			this.button_visualization.Click += new System.EventHandler(this.OnStartVisualization);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1105, 574);
			this.Controls.Add(groupBox_info);
			this.Controls.Add(this.button_visualization);
			this.Controls.Add(groupBox_paramSimulation);
			this.Controls.Add(groupBox_paramSystem);
			this.Controls.Add(this.button_createModel);
			this.Controls.Add(this.button_startCalculate);
			this.Controls.Add(this.button_stopCalculate);
			this.Controls.Add(this.button_clear);
			this.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Location = new System.Drawing.Point(15, 15);
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			groupBox_paramSystem.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_temp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_size)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_velocitySystem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_countAtoms)).EndInit();
			groupBox_paramSimulation.ResumeLayout(false);
			groupBox_paramSimulation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_dt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_dt_e)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_snapshotStep)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_countStep)).EndInit();
			groupBox_info.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart_energy)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.NumericUpDown numUpDown_temp;

		private System.Windows.Forms.NumericUpDown numUpDown_size;

		private System.Windows.Forms.Button button_visualization;

		private System.Windows.Forms.NumericUpDown numUpDown_dt;
		private System.Windows.Forms.NumericUpDown numUpDown_dt_e;
		private System.Windows.Forms.NumericUpDown numUpDown_snapshotStep;
		private System.Windows.Forms.NumericUpDown numUpDown_countStep;

		private System.Windows.Forms.NumericUpDown numUpDown_velocitySystem;

		private System.Windows.Forms.NumericUpDown numUpDown_countAtoms;

		private System.Windows.Forms.Button button_createModel;
		private System.Windows.Forms.RichTextBox richTextBox_outputWnd;

		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart_energy;
		private System.Windows.Forms.Button button_clear;
		private System.Windows.Forms.Button button_stopCalculate;
		private System.Windows.Forms.Button button_startCalculate;
	}
}

