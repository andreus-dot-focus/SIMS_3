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
        const decimal g = 9.81M;
        const decimal C = 0.15M;
        const decimal rho = 1.29M;

        decimal cosa;
        decimal sina;
        decimal S;
        decimal m;
        decimal k;
        decimal vx;
        decimal vy;

        decimal dt;

        double a;
        decimal v0;
        decimal y0;

        decimal t;
        decimal x;
        decimal y;

        bool isModeling = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (isModeling == false)
            {
                dt = 0.1M;
                a = (double)edAngle.Value * Math.PI / 180;
                v0 = (decimal)edSpeed.Value;
                y0 = (decimal)edHeight.Value;

                cosa = (decimal)Math.Cos(a);
                sina = (decimal)Math.Sin(a);
                S = edSize.Value;
                m = edWeight.Value;
                k = 0.5M * C * rho * S / m;
                vx = v0 * cosa;
                vy = v0 * sina;


                t = 0;
                x = 0;
                y = y0;
                chart1.Series[0].Points.Clear();
                chart1.Series[0].Points.AddXY(x, y);

                isModeling = true;
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += dt*10000;
            timeValueLabel.Text = $"{(int)t / 60000}.{(int)t / 1000}.{(int)t % 1000}";

            decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;

            chart1.Series[0].Points.AddXY(x, y);
            if (y <= 0)
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

