using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace molecular_dynamics_2_2_3
{
    public partial class VisualizationForm : Form
    {
        private Drawing _drawing;
        private List<Vector2D>[] _atomsPositon;
        private int _countStep;
        
        public VisualizationForm(List<Vector2D>[] atomsPositon, double l)
        {
            InitializeComponent();
            _countStep = atomsPositon.Length;
            trackBar_timeStep.Maximum = _countStep;
            _drawing = new Drawing(pictureBox_visualizastion, 0, 0, l, l);
            _atomsPositon = new List<Vector2D>[_countStep];
            for (var i = 0; i < _countStep; i++)
            {
                _atomsPositon[i] = new List<Vector2D>();
                atomsPositon[i].ForEach(pos => _atomsPositon[i].Add(pos));
            }
            _drawing.DrawAtoms(Color.Blue, _atomsPositon[0], PotentialMlj.ParamsMljAr.R0);
        }

        private void OnAnimation(object sender, EventArgs e)
        {
            _drawing.Clear();
            _drawing.DrawAtoms(Color.Blue, _atomsPositon[trackBar_timeStep.Value], PotentialMlj.ParamsMljAr.R0);
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