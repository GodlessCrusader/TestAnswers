using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaComputer
{
    public class Circle : GeometricalFigure
    {
        public Circle(double radius, double dx = 0.001)
        {
            chunks = new List<Chunk>() {
                new Chunk(0,
                    radius * 2,
                    dx,
                    (x) => { return radius + Math.Sqrt(Math.Pow(radius,2) - Math.Pow(x - radius,2)); },
                    (x) => { return radius - Math.Sqrt(Math.Pow(radius,2) - Math.Pow(x - radius,2)); }
            )};
            ComputeArea();
        }
    }
}
