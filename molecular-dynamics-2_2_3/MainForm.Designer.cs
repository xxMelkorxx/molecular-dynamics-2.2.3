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
			System.Windows.Forms.Label label_size;
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
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.radioButton_randomSystem = new System.Windows.Forms.RadioButton();
			this.radioButton_orderlySystem = new System.Windows.Forms.RadioButton();
			this.numUpDown_temp = new System.Windows.Forms.NumericUpDown();
			this.numUpDown_size = new System.Windows.Forms.NumericUpDown();
			this.numUpDown_countAtoms = new System.Windows.Forms.NumericUpDown();
			this.checkBox_isSpapshot = new System.Windows.Forms.CheckBox();
			this.numUpDown_dt = new System.Windows.Forms.NumericUpDown();
			this.numUpDown_dt_e = new System.Windows.Forms.NumericUpDown();
			this.numUpDown_snapshotStep = new System.Windows.Forms.NumericUpDown();
			this.numUpDown_countStep = new System.Windows.Forms.NumericUpDown();
			this.chart_speedDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart_energy = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.richTextBox_outputWnd = new System.Windows.Forms.RichTextBox();
			this.button_clear = new System.Windows.Forms.Button();
			this.button_stopCalculate = new System.Windows.Forms.Button();
			this.button_startCalculate = new System.Windows.Forms.Button();
			this.button_createModel = new System.Windows.Forms.Button();
			this.button_visualization = new System.Windows.Forms.Button();
			this.progressBar_calculation = new System.Windows.Forms.ProgressBar();
			this.button_saveDistributionSpeed = new System.Windows.Forms.Button();
			groupBox_paramSystem = new System.Windows.Forms.GroupBox();
			label_temp = new System.Windows.Forms.Label();
			label_size = new System.Windows.Forms.Label();
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
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_countAtoms)).BeginInit();
			groupBox_paramSimulation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_dt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_dt_e)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_snapshotStep)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_countStep)).BeginInit();
			groupBox_info.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart_speedDistribution)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart_energy)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox_paramSystem
			// 
			groupBox_paramSystem.Controls.Add(this.radioButton_randomSystem);
			groupBox_paramSystem.Controls.Add(this.radioButton_orderlySystem);
			groupBox_paramSystem.Controls.Add(this.numUpDown_temp);
			groupBox_paramSystem.Controls.Add(label_temp);
			groupBox_paramSystem.Controls.Add(this.numUpDown_size);
			groupBox_paramSystem.Controls.Add(label_size);
			groupBox_paramSystem.Controls.Add(this.numUpDown_countAtoms);
			groupBox_paramSystem.Controls.Add(label_countAtoms);
			groupBox_paramSystem.Location = new System.Drawing.Point(701, 13);
			groupBox_paramSystem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			groupBox_paramSystem.Name = "groupBox_paramSystem";
			groupBox_paramSystem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			groupBox_paramSystem.Size = new System.Drawing.Size(288, 187);
			groupBox_paramSystem.TabIndex = 8;
			groupBox_paramSystem.TabStop = false;
			groupBox_paramSystem.Text = "Параметры системы";
			// 
			// radioButton_randomSystem
			// 
			this.radioButton_randomSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton_randomSystem.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.radioButton_randomSystem.Checked = true;
			this.radioButton_randomSystem.Location = new System.Drawing.Point(13, 155);
			this.radioButton_randomSystem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radioButton_randomSystem.Name = "radioButton_randomSystem";
			this.radioButton_randomSystem.Size = new System.Drawing.Size(269, 22);
			this.radioButton_randomSystem.TabIndex = 15;
			this.radioButton_randomSystem.TabStop = true;
			this.radioButton_randomSystem.Text = "Случайная система";
			this.radioButton_randomSystem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.radioButton_randomSystem.UseVisualStyleBackColor = true;
			// 
			// radioButton_orderlySystem
			// 
			this.radioButton_orderlySystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton_orderlySystem.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.radioButton_orderlySystem.Location = new System.Drawing.Point(13, 125);
			this.radioButton_orderlySystem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radioButton_orderlySystem.Name = "radioButton_orderlySystem";
			this.radioButton_orderlySystem.Size = new System.Drawing.Size(269, 22);
			this.radioButton_orderlySystem.TabIndex = 14;
			this.radioButton_orderlySystem.Text = "Упорядоченная система";
			this.radioButton_orderlySystem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.radioButton_orderlySystem.UseVisualStyleBackColor = true;
			// 
			// numUpDown_temp
			// 
			this.numUpDown_temp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numUpDown_temp.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numUpDown_temp.Location = new System.Drawing.Point(196, 92);
			this.numUpDown_temp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numUpDown_temp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numUpDown_temp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numUpDown_temp.Name = "numUpDown_temp";
			this.numUpDown_temp.Size = new System.Drawing.Size(86, 25);
			this.numUpDown_temp.TabIndex = 12;
			this.numUpDown_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUpDown_temp.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			// 
			// label_temp
			// 
			label_temp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_temp.Location = new System.Drawing.Point(13, 92);
			label_temp.Name = "label_temp";
			label_temp.Size = new System.Drawing.Size(177, 25);
			label_temp.TabIndex = 13;
			label_temp.Text = "Температура:";
			label_temp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numUpDown_size
			// 
			this.numUpDown_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numUpDown_size.Location = new System.Drawing.Point(196, 26);
			this.numUpDown_size.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numUpDown_size.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numUpDown_size.Name = "numUpDown_size";
			this.numUpDown_size.Size = new System.Drawing.Size(86, 25);
			this.numUpDown_size.TabIndex = 10;
			this.numUpDown_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUpDown_size.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// label_size
			// 
			label_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_size.Location = new System.Drawing.Point(10, 26);
			label_size.Name = "label_size";
			label_size.Size = new System.Drawing.Size(180, 25);
			label_size.TabIndex = 11;
			label_size.Text = "Размер ячейки:";
			label_size.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numUpDown_countAtoms
			// 
			this.numUpDown_countAtoms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numUpDown_countAtoms.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numUpDown_countAtoms.Location = new System.Drawing.Point(196, 59);
			this.numUpDown_countAtoms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numUpDown_countAtoms.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numUpDown_countAtoms.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numUpDown_countAtoms.Name = "numUpDown_countAtoms";
			this.numUpDown_countAtoms.Size = new System.Drawing.Size(86, 25);
			this.numUpDown_countAtoms.TabIndex = 6;
			this.numUpDown_countAtoms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUpDown_countAtoms.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
			// 
			// label_countAtoms
			// 
			label_countAtoms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_countAtoms.Location = new System.Drawing.Point(13, 59);
			label_countAtoms.Name = "label_countAtoms";
			label_countAtoms.Size = new System.Drawing.Size(177, 25);
			label_countAtoms.TabIndex = 7;
			label_countAtoms.Text = "Число атомов:";
			label_countAtoms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox_paramSimulation
			// 
			groupBox_paramSimulation.Controls.Add(this.checkBox_isSpapshot);
			groupBox_paramSimulation.Controls.Add(label_dt);
			groupBox_paramSimulation.Controls.Add(label_e);
			groupBox_paramSimulation.Controls.Add(this.numUpDown_dt);
			groupBox_paramSimulation.Controls.Add(this.numUpDown_dt_e);
			groupBox_paramSimulation.Controls.Add(label_snapshotStep);
			groupBox_paramSimulation.Controls.Add(this.numUpDown_snapshotStep);
			groupBox_paramSimulation.Controls.Add(label_countStep);
			groupBox_paramSimulation.Controls.Add(this.numUpDown_countStep);
			groupBox_paramSimulation.Location = new System.Drawing.Point(701, 208);
			groupBox_paramSimulation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			groupBox_paramSimulation.Name = "groupBox_paramSimulation";
			groupBox_paramSimulation.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			groupBox_paramSimulation.Size = new System.Drawing.Size(288, 155);
			groupBox_paramSimulation.TabIndex = 9;
			groupBox_paramSimulation.TabStop = false;
			groupBox_paramSimulation.Text = "Параметры моделирования";
			// 
			// checkBox_isSpapshot
			// 
			this.checkBox_isSpapshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox_isSpapshot.AutoSize = true;
			this.checkBox_isSpapshot.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox_isSpapshot.Location = new System.Drawing.Point(95, 92);
			this.checkBox_isSpapshot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.checkBox_isSpapshot.Name = "checkBox_isSpapshot";
			this.checkBox_isSpapshot.Size = new System.Drawing.Size(187, 21);
			this.checkBox_isSpapshot.TabIndex = 13;
			this.checkBox_isSpapshot.Text = "Выводить информацию?";
			this.checkBox_isSpapshot.UseVisualStyleBackColor = true;
			// 
			// label_dt
			// 
			label_dt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_dt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			label_dt.Location = new System.Drawing.Point(13, 26);
			label_dt.Name = "label_dt";
			label_dt.Size = new System.Drawing.Size(138, 25);
			label_dt.TabIndex = 36;
			label_dt.Text = "Временной шаг:";
			label_dt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label_e
			// 
			label_e.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_e.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			label_e.Location = new System.Drawing.Point(209, 26);
			label_e.Name = "label_e";
			label_e.Size = new System.Drawing.Size(16, 25);
			label_e.TabIndex = 35;
			label_e.Text = "e";
			label_e.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numUpDown_dt
			// 
			this.numUpDown_dt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numUpDown_dt.Location = new System.Drawing.Point(157, 26);
			this.numUpDown_dt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numUpDown_dt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numUpDown_dt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numUpDown_dt.Name = "numUpDown_dt";
			this.numUpDown_dt.Size = new System.Drawing.Size(46, 25);
			this.numUpDown_dt.TabIndex = 34;
			this.numUpDown_dt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUpDown_dt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numUpDown_dt_e
			// 
			this.numUpDown_dt_e.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numUpDown_dt_e.Location = new System.Drawing.Point(231, 26);
			this.numUpDown_dt_e.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numUpDown_dt_e.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.numUpDown_dt_e.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.numUpDown_dt_e.Name = "numUpDown_dt_e";
			this.numUpDown_dt_e.Size = new System.Drawing.Size(51, 25);
			this.numUpDown_dt_e.TabIndex = 33;
			this.numUpDown_dt_e.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUpDown_dt_e.Value = new decimal(new int[] {
            14,
            0,
            0,
            -2147483648});
			// 
			// label_snapshotStep
			// 
			label_snapshotStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_snapshotStep.Location = new System.Drawing.Point(13, 121);
			label_snapshotStep.Name = "label_snapshotStep";
			label_snapshotStep.Size = new System.Drawing.Size(177, 25);
			label_snapshotStep.TabIndex = 32;
			label_snapshotStep.Text = "Шаг снимков системы:";
			label_snapshotStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numUpDown_snapshotStep
			// 
			this.numUpDown_snapshotStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numUpDown_snapshotStep.Location = new System.Drawing.Point(196, 121);
			this.numUpDown_snapshotStep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numUpDown_snapshotStep.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numUpDown_snapshotStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numUpDown_snapshotStep.Name = "numUpDown_snapshotStep";
			this.numUpDown_snapshotStep.Size = new System.Drawing.Size(86, 25);
			this.numUpDown_snapshotStep.TabIndex = 31;
			this.numUpDown_snapshotStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUpDown_snapshotStep.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// label_countStep
			// 
			label_countStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_countStep.Location = new System.Drawing.Point(13, 59);
			label_countStep.Name = "label_countStep";
			label_countStep.Size = new System.Drawing.Size(177, 25);
			label_countStep.TabIndex = 30;
			label_countStep.Text = "Временных шагов:";
			label_countStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numUpDown_countStep
			// 
			this.numUpDown_countStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numUpDown_countStep.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numUpDown_countStep.Location = new System.Drawing.Point(196, 59);
			this.numUpDown_countStep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numUpDown_countStep.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numUpDown_countStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numUpDown_countStep.Name = "numUpDown_countStep";
			this.numUpDown_countStep.Size = new System.Drawing.Size(86, 25);
			this.numUpDown_countStep.TabIndex = 29;
			this.numUpDown_countStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUpDown_countStep.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// groupBox_info
			// 
			groupBox_info.Controls.Add(this.chart_speedDistribution);
			groupBox_info.Controls.Add(this.chart_energy);
			groupBox_info.Controls.Add(this.richTextBox_outputWnd);
			groupBox_info.Location = new System.Drawing.Point(12, 13);
			groupBox_info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			groupBox_info.Name = "groupBox_info";
			groupBox_info.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			groupBox_info.Size = new System.Drawing.Size(683, 705);
			groupBox_info.TabIndex = 11;
			groupBox_info.TabStop = false;
			groupBox_info.Text = "Инфографика";
			// 
			// chart_speedDistribution
			// 
			this.chart_speedDistribution.BorderlineColor = System.Drawing.Color.DimGray;
			this.chart_speedDistribution.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea1.AxisX.Interval = 200D;
			chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea1.AxisX.Minimum = 0D;
			chartArea1.AxisX.Title = "Скорость атомов, м/с";
			chartArea1.AxisX.TitleFont = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea1.AxisY.Minimum = 0D;
			chartArea1.AxisY.Title = "Отн. число атомов";
			chartArea1.AxisY.TitleFont = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea1.Name = "ChartArea1";
			this.chart_speedDistribution.ChartAreas.Add(chartArea1);
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
			legend1.DockedToChartArea = "ChartArea1";
			legend1.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			legend1.IsTextAutoFit = false;
			legend1.Name = "Legend1";
			legend1.TitleFont = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chart_speedDistribution.Legends.Add(legend1);
			this.chart_speedDistribution.Location = new System.Drawing.Point(6, 234);
			this.chart_speedDistribution.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chart_speedDistribution.Name = "chart_speedDistribution";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
			series1.Color = System.Drawing.Color.Blue;
			series1.EmptyPointStyle.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
			series1.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			series1.Legend = "Legend1";
			series1.LegendText = "Распеределение по скоростям";
			series1.Name = "speedDistribution";
			series1.YValuesPerPoint = 2;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Color = System.Drawing.Color.Red;
			series2.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			series2.IsVisibleInLegend = false;
			series2.Legend = "Legend1";
			series2.LegendText = "Распеределение Максвелла";
			series2.Name = "maxwellDistribution";
			series3.BorderWidth = 2;
			series3.ChartArea = "ChartArea1";
			series3.Color = System.Drawing.Color.Cyan;
			series3.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			series3.IsVisibleInLegend = false;
			series3.Legend = "Legend1";
			series3.LegendText = "Вероятная скорость";
			series3.Name = "mostLikelySpeed";
			series4.BorderWidth = 2;
			series4.ChartArea = "ChartArea1";
			series4.Color = System.Drawing.Color.Lime;
			series4.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			series4.IsVisibleInLegend = false;
			series4.Legend = "Legend1";
			series4.LegendText = "Средняя скорость";
			series4.Name = "averageSpeed";
			series5.BorderWidth = 2;
			series5.ChartArea = "ChartArea1";
			series5.Color = System.Drawing.Color.Fuchsia;
			series5.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			series5.IsVisibleInLegend = false;
			series5.Legend = "Legend1";
			series5.LegendText = "Среднеквадратичная скорость";
			series5.Name = "sqrtSpeed";
			this.chart_speedDistribution.Series.Add(series1);
			this.chart_speedDistribution.Series.Add(series2);
			this.chart_speedDistribution.Series.Add(series3);
			this.chart_speedDistribution.Series.Add(series4);
			this.chart_speedDistribution.Series.Add(series5);
			this.chart_speedDistribution.Size = new System.Drawing.Size(666, 250);
			this.chart_speedDistribution.TabIndex = 8;
			// 
			// chart_energy
			// 
			this.chart_energy.BorderlineColor = System.Drawing.Color.DimGray;
			this.chart_energy.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea2.AxisX.Minimum = 0D;
			chartArea2.AxisX.Title = "Временной шаг";
			chartArea2.AxisX.TitleFont = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea2.AxisX2.TitleFont = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea2.AxisY.Title = "Энергия (эВ)";
			chartArea2.AxisY.TitleFont = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea2.AxisY2.TitleFont = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea2.Name = "ChartArea1";
			this.chart_energy.ChartAreas.Add(chartArea2);
			legend2.BackColor = System.Drawing.Color.Transparent;
			legend2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
			legend2.DockedToChartArea = "ChartArea1";
			legend2.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			legend2.IsTextAutoFit = false;
			legend2.Name = "Legend1";
			this.chart_energy.Legends.Add(legend2);
			this.chart_energy.Location = new System.Drawing.Point(6, 26);
			this.chart_energy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chart_energy.Name = "chart_energy";
			series6.ChartArea = "ChartArea1";
			series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series6.Color = System.Drawing.Color.Red;
			series6.Legend = "Legend1";
			series6.LegendText = "Кинетическая энергия";
			series6.Name = "ke";
			series7.ChartArea = "ChartArea1";
			series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series7.Color = System.Drawing.Color.Blue;
			series7.Legend = "Legend1";
			series7.LegendText = "Потенциальная энергия";
			series7.Name = "pe";
			series8.ChartArea = "ChartArea1";
			series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series8.Color = System.Drawing.Color.Green;
			series8.Legend = "Legend1";
			series8.LegendText = "Полная энергия";
			series8.Name = "fe";
			this.chart_energy.Series.Add(series6);
			this.chart_energy.Series.Add(series7);
			this.chart_energy.Series.Add(series8);
			this.chart_energy.Size = new System.Drawing.Size(666, 200);
			this.chart_energy.TabIndex = 2;
			this.chart_energy.Text = "Графики энергий";
			// 
			// richTextBox_outputWnd
			// 
			this.richTextBox_outputWnd.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBox_outputWnd.Location = new System.Drawing.Point(6, 492);
			this.richTextBox_outputWnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.richTextBox_outputWnd.Name = "richTextBox_outputWnd";
			this.richTextBox_outputWnd.Size = new System.Drawing.Size(667, 200);
			this.richTextBox_outputWnd.TabIndex = 7;
			this.richTextBox_outputWnd.Text = "";
			// 
			// button_clear
			// 
			this.button_clear.Enabled = false;
			this.button_clear.Location = new System.Drawing.Point(524, 726);
			this.button_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button_clear.Name = "button_clear";
			this.button_clear.Size = new System.Drawing.Size(171, 25);
			this.button_clear.TabIndex = 3;
			this.button_clear.Text = "Очистить";
			this.button_clear.UseVisualStyleBackColor = true;
			this.button_clear.Click += new System.EventHandler(this.OnClearRichBoxInfo);
			// 
			// button_stopCalculate
			// 
			this.button_stopCalculate.Enabled = false;
			this.button_stopCalculate.Location = new System.Drawing.Point(701, 660);
			this.button_stopCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button_stopCalculate.Name = "button_stopCalculate";
			this.button_stopCalculate.Size = new System.Drawing.Size(288, 25);
			this.button_stopCalculate.TabIndex = 4;
			this.button_stopCalculate.Text = "Остановить";
			this.button_stopCalculate.UseVisualStyleBackColor = true;
			this.button_stopCalculate.Click += new System.EventHandler(this.OnStopCalculate);
			// 
			// button_startCalculate
			// 
			this.button_startCalculate.Enabled = false;
			this.button_startCalculate.Location = new System.Drawing.Point(701, 627);
			this.button_startCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button_startCalculate.Name = "button_startCalculate";
			this.button_startCalculate.Size = new System.Drawing.Size(288, 25);
			this.button_startCalculate.TabIndex = 5;
			this.button_startCalculate.Text = "Запуск вычисления";
			this.button_startCalculate.UseVisualStyleBackColor = true;
			this.button_startCalculate.Click += new System.EventHandler(this.OnStartCalculate);
			// 
			// button_createModel
			// 
			this.button_createModel.Location = new System.Drawing.Point(701, 594);
			this.button_createModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button_createModel.Name = "button_createModel";
			this.button_createModel.Size = new System.Drawing.Size(288, 25);
			this.button_createModel.TabIndex = 6;
			this.button_createModel.Text = "Создать модель";
			this.button_createModel.UseVisualStyleBackColor = true;
			this.button_createModel.Click += new System.EventHandler(this.OnCreateModel);
			// 
			// button_visualization
			// 
			this.button_visualization.Enabled = false;
			this.button_visualization.Location = new System.Drawing.Point(701, 693);
			this.button_visualization.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button_visualization.Name = "button_visualization";
			this.button_visualization.Size = new System.Drawing.Size(288, 25);
			this.button_visualization.TabIndex = 10;
			this.button_visualization.Text = "Визуализировать";
			this.button_visualization.UseVisualStyleBackColor = true;
			this.button_visualization.Click += new System.EventHandler(this.OnStartVisualization);
			// 
			// progressBar_calculation
			// 
			this.progressBar_calculation.Location = new System.Drawing.Point(12, 725);
			this.progressBar_calculation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.progressBar_calculation.Name = "progressBar_calculation";
			this.progressBar_calculation.Size = new System.Drawing.Size(506, 25);
			this.progressBar_calculation.Step = 1;
			this.progressBar_calculation.TabIndex = 12;
			// 
			// button_saveDistributionSpeed
			// 
			this.button_saveDistributionSpeed.Enabled = false;
			this.button_saveDistributionSpeed.Location = new System.Drawing.Point(701, 726);
			this.button_saveDistributionSpeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button_saveDistributionSpeed.Name = "button_saveDistributionSpeed";
			this.button_saveDistributionSpeed.Size = new System.Drawing.Size(288, 25);
			this.button_saveDistributionSpeed.TabIndex = 13;
			this.button_saveDistributionSpeed.Text = "Сохранить распределение в файл";
			this.button_saveDistributionSpeed.UseVisualStyleBackColor = true;
			this.button_saveDistributionSpeed.Click += new System.EventHandler(this.OnClickButtonSaveDistributionSpeed);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(996, 763);
			this.Controls.Add(this.button_saveDistributionSpeed);
			this.Controls.Add(this.progressBar_calculation);
			this.Controls.Add(groupBox_info);
			this.Controls.Add(this.button_visualization);
			this.Controls.Add(groupBox_paramSimulation);
			this.Controls.Add(groupBox_paramSystem);
			this.Controls.Add(this.button_createModel);
			this.Controls.Add(this.button_startCalculate);
			this.Controls.Add(this.button_stopCalculate);
			this.Controls.Add(this.button_clear);
			this.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Location = new System.Drawing.Point(15, 15);
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			groupBox_paramSystem.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_temp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_size)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_countAtoms)).EndInit();
			groupBox_paramSimulation.ResumeLayout(false);
			groupBox_paramSimulation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_dt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_dt_e)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_snapshotStep)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_countStep)).EndInit();
			groupBox_info.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart_speedDistribution)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart_energy)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.NumericUpDown numUpDown_temp;
		private System.Windows.Forms.NumericUpDown numUpDown_size;
		private System.Windows.Forms.NumericUpDown numUpDown_dt;
		private System.Windows.Forms.NumericUpDown numUpDown_dt_e;
		private System.Windows.Forms.NumericUpDown numUpDown_snapshotStep;
		private System.Windows.Forms.NumericUpDown numUpDown_countStep;
		private System.Windows.Forms.NumericUpDown numUpDown_countAtoms;
		private System.Windows.Forms.Button button_createModel;
		private System.Windows.Forms.Button button_visualization;
		private System.Windows.Forms.Button button_clear;
		private System.Windows.Forms.Button button_stopCalculate;
		private System.Windows.Forms.Button button_startCalculate;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart_speedDistribution;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart_energy;
		private System.Windows.Forms.RichTextBox richTextBox_outputWnd;
		private System.Windows.Forms.RadioButton radioButton_orderlySystem;
		private System.Windows.Forms.RadioButton radioButton_randomSystem;
		private System.Windows.Forms.ProgressBar progressBar_calculation;
		private System.Windows.Forms.CheckBox checkBox_isSpapshot;
		private System.Windows.Forms.Button button_saveDistributionSpeed;
	}
}

