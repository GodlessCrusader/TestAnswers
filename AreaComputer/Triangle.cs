namespace AreaComputer
{
    public class Triangle : GeometricalFigure
    {
        public Triangle(double a, double b, double c) : base(
            (arg) => {
                var p = (arg[0] + arg[1] + arg[2]) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));},
            new List<double>() { a, b, c })
        
        {
            SetSides(a, b, c);
            
            /*
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
            ComputeAreaWithChunks();*/
        }
        public void SetSides(double a, double b, double c)
        {
            if (!(a + b > c && a + c > b && b + c > a) || (a <= 0 || b <= 0 || c <= 0))
                throw new ArgumentException("Wrong input data");

            if (a == b && c == b)
                IsRight = true;

            var angleC = Math.Acos((a * a + b * b - c * c) / (2 * a * b));

            var angleB = Math.Acos((a * a + c * c - b * b) / (2 * a * c));

            var angleA = Math.Acos((b * b + c * c - a * a) / (2 * b * c));

            if (angleA == Math.PI / 2 || angleB == Math.PI / 2 || angleC == Math.PI / 2)
                HasSquareAngle = true;

            areaArgs = new List<double>() { a, b, c };
            ComputeAreaWithFormule();
        }

        public bool IsRight { get; private set; } = false;
        
        public bool HasSquareAngle { get; private set; } = false;
    }
}