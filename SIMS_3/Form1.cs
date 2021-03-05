using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS_3
{
    public partial class Form1 : Form
    {
        bool isModeling = false;
        Calculations calc;

        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (isModeling == false)
            {
                calc = new Calculations((double)edAngle.Value * Math.PI / 180, edSpeed.Value, edHeight.Value, edSize.Value, edWeight.Value);

                chart1.Series[0].Points.Clear();
                chart1.Series[0].Points.AddXY(calc.GetX(), calc.GetY());

                isModeling = true;
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            decimal t = calc.GetTime();
            timeValueLabel.Text = $"{(int)t / 60000}.{(int)t / 1000}.{(int)t % 1000}";

            calc.RungeKutta();
            chart1.Series[0].Points.AddXY(calc.GetX(), calc.GetY());
            if (calc.GetY() <= 0)
            {
                timer1.Stop();
                isModeling = false;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}

