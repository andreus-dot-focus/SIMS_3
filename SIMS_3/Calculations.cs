using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_3
{
    class Calculations
    {
        const decimal g = 9.81M;
        const decimal C = 0.15M;
        const decimal rho = 1.29M;

        const decimal dt = 0.1M;

        decimal cosa;
        decimal sina;

        decimal k;
        decimal vx;
        decimal vy;

        double a;

        decimal x;
        decimal y;
        decimal t;

        public Calculations(double a, decimal v0, decimal y0, decimal S, decimal m){
            this.a = a;

            cosa = (decimal)Math.Cos(a);
            sina = (decimal)Math.Sin(a);

            k = 0.5M * C * rho * S / m;
            vx = v0 * cosa;
            vy = v0 * sina;

            t = 0;
            x = 0;
            y = y0;
        }

        public void RungeKutta() {
            t += dt * 10000;

            decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;
        }

        public decimal GetX() 
        {
            return x;
        }

        public decimal GetY()
        {
            return y;
        }

        public decimal GetTime() {
            return t;
        }
    }
}
