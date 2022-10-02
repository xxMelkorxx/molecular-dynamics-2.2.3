using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace molecular_dynamics_2_2_3
{
    public partial class VisualizationForm : Form
    {
        private Drawing _drawing;
        private List<List<Vector2D>> _atomsPositon;
        
        public VisualizationForm(List<List<Vector2D>> atomsPositon, double l)
        {
            InitializeComponent();
            
            trackBar_timeStep.Maximum = atomsPositon.Count - 1;
            
            _drawing = new Drawing(pictureBox_visualizastion, 0, 0, l, l);
            _drawing.Clear();
            _atomsPositon = atomsPositon;
            
            _drawing.DrawAtoms(_atomsPositon[0], PotentialMlj.ParamsMljAr.R0);
        }

        private void OnAnimation(object sender, EventArgs e)
        {
            _drawing.Clear();
            _drawing.DrawAtoms(_atomsPositon[trackBar_timeStep.Value], PotentialMlj.ParamsMljAr.R0);
        }

        private void OnStartAnimation(object sender, EventArgs e)
        {
            if (button_start.Text == "Старт")
            {
                timer.Start();
                button_start.Text = "Стоп";
            }
            else
            {
                timer.Stop();
                button_start.Text = "Старт";
            }
        }

        private void OnTickTimer(object sender, EventArgs e)
        {
            if (trackBar_timeStep.Value < trackBar_timeStep.Maximum)
                trackBar_timeStep.Value++;
            else trackBar_timeStep.Value = 0;
        }
    }
}