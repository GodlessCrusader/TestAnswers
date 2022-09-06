namespace AreaComputer
{
    public class Triangle : GeometricalFigure
    {
        public Triangle(double a, double b, double c, double dx =0.001)
        {
            if (!(a + b > c && a + c > b && b + c > a) || (a < 0 || b < 0 || c < 0))
                throw new Exception("Wrong input data");
            
            if(a == b && c == b)
                IsRight = true;
            
            var angleC = Math.Acos((a * a + b * b - c * c) / (2 * a * b));

            var angleB = Math.Acos((a * a + c * c - b * b) / (2 * a * c));

            var angleA = Math.PI - angleC - angleB;

            if (angleA == Math.PI / 2 || angleB == Math.PI / 2 || angleC == Math.PI / 2)
                HasSquareAngle = true;
            

            chunks = new List<Chunk>() {
                new Chunk(0,
                    a - Math.Cos(angleB) * c,
                    dx,
                    (x) => { return x * Math.Tan(angleC); },
                    (x) => { return 0; }),
                new Chunk(a - Math.Cos(angleB) * c,
                    a,
                    dx,
                    (x) => { return -1 * Math.Tan(angleB)*x + (Math.Cos(angleB) * c) * Math.Tan(angleB); },
                    (x) => { return 0; } )
            };
            ComputeArea();
        }
        public bool IsRight { get; private set; } = false;
        public bool HasSquareAngle { get; private set; } = false;
    }
}