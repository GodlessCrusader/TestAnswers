using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaComputer
{
    public class Circle : GeometricalFigure
    {
        public Circle(double radius) : base(
            (r) => { return Math.PI * r[0] * r[0]; },
            new List<double>() { radius })
        {
            if (radius <= 0)
                throw new ArgumentException("Wrong input data");
        }

        public Circle(double radius, double dx) : base( new List<Chunk>() {
                
            new Chunk(0,
                    radius * 2,
                    dx,
                    (x) => { return radius + Math.Sqrt(Math.Pow(radius,2) - Math.Pow(x - radius,2)); },
                    (x) => { return radius - Math.Sqrt(Math.Pow(radius,2) - Math.Pow(x - radius,2)); }
            )})
        {
            if (radius <= 0)
                throw new ArgumentException("Wrong input data");
            _radius = radius;
            AreaComputeFormule = (r) => { return Math.PI * r[0] * r[0]; };
            areaArgs = new List<double>() {_radius};
            
            ComputeAreaWithChunks();
        }
        private double _radius;
        public double Radius 
        {
            get { return _radius; } 
            set { 
                if (value <= 0)
                    throw new ArgumentException("Wrong input data");
                _radius=value;
                areaArgs = new List<double>() { _radius };
                ComputeAreaWithFormule();
            } 
        }
    }
}
