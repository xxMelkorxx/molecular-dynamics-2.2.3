using System.ComponentModel;

namespace molecular_dynamics_2_2_3
{
    partial class VisualizationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.pictureBox_visualizastion = new System.Windows.Forms.PictureBox();
            this.trackBar_timeStep = new System.Windows.Forms.TrackBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_visualizastion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_timeStep)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_visualizastion
            // 
            this.pictureBox_visualizastion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_visualizastion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_visualizastion.Location = new System.Drawing.Point(14, 13);
            this.pictureBox_visualizastion.Name = "pictureBox_visualizastion";
            this.pictureBox_visualizastion.Size = new System.Drawing.Size(600, 600);
            this.pictureBox_visualizastion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_visualizastion.TabIndex = 0;
            this.pictureBox_visualizastion.TabStop = false;
            // 
            // trackBar_timeStep
            // 
            this.trackBar_timeStep.LargeChange = 1;
            this.trackBar_timeStep.Location = new System.Drawing.Point(14, 619);
            this.trackBar_timeStep.Name = "trackBar_timeStep";
            this.trackBar_timeStep.Size = new System.Drawing.Size(600, 45);
            this.trackBar_timeStep.TabIndex = 1;
            this.trackBar_timeStep.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_timeStep.ValueChanged += new System.EventHandler(this.OnValueChangedTrackBar);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.OnTickTimer);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(14, 670);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(600, 31);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Старт";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.OnStartAnimation);
            // 
            // VisualizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(629, 708);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.trackBar_timeStep);
            this.Controls.Add(this.pictureBox_visualizastion);
            this.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "VisualizationForm";
            this.Text = "Визуализация системы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_visualizastion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_timeStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button_start;

        private System.Windows.Forms.TrackBar trackBar_timeStep;
        private System.Windows.Forms.Timer timer;

        private System.Windows.Forms.PictureBox pictureBox_visualizastion;

        #endregion
    }
}