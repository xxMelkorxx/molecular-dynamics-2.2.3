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
        private double _l;
        
        public VisualizationForm(List<List<Vector2D>> atomsPositon, double l)
        {
            InitializeComponent();
            _l = l;
            trackBar_timeStep.Maximum = atomsPositon.Count - 1;
            
            _drawing = new Drawing(pictureBox_visualizastion, 0, 0, _l, _l);
            _atomsPositon = atomsPositon;
            
            _drawing.DrawAtoms(_atomsPositon[0], PotentialMlj.ParamsMljAr.Sigma, _l);
        }

        private void OnValueChangedTrackBar(object sender, EventArgs e)
        {
            var idx = trackBar_timeStep.Value;
            _drawing = new Drawing(pictureBox_visualizastion, 0, 0, _l, _l);
            _drawing.DrawAtoms(_atomsPositon[idx], PotentialMlj.ParamsMljAr.Sigma, _l);
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