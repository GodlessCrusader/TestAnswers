using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaComputer
{
    public class Chunk
    {
        public Chunk(double x0, double x, double dx, Func<double, double> f1, Func<double, double> f2)
        {
            this.x0 = x0;
            this.x = x;
            this.F1 = f1;
            this.F2 = f2;
            Area = this.Integral(dx);
        }

        private double x0 { get; set; }
        private double x { get; set; }

        private Func<double, double> F1;
        private Func<double, double> F2;
        public double Area { get; private set; }
        private double Integral(double dx)
        {
            double s = 0;
            for (double i = x0; i < x - dx; i += dx)
            {
                s += (F1(i) - F2(i) + F1(i + dx) - F2(i + dx)) * dx / 2;
            }
            return Math.Round(s);
        }
    }
}
