// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the Area computer menu!");
Console.WriteLine("Press 1, to select triangle mode\nPress 2, to select circle mode");
var s = Console.ReadLine();
if(int.Parse(s) == 1)
{
    double[] sides = new double[3];
    Console.WriteLine("Enter 3 sides:\na: ");
    sides[0] = double.Parse(Console.ReadLine());
    Console.WriteLine("b: ");
    sides[1] = double.Parse(Console.ReadLine());
    Console.WriteLine("c: ");
    sides[2] = double.Parse(Console.ReadLine());
    var triangle = new AreaComputer.Triangle(sides[0], sides[1], sides[2]);
    Console.WriteLine($"Triangle area:{string.Format("{0:0.000}", triangle.Area)} has square angle:{triangle.HasSquareAngle}");
}
if (int.Parse(s) == 2)
{
    Console.WriteLine("Enter radius:");
    var radius = double.Parse(Console.ReadLine());
    var circle = new AreaComputer.Circle(radius);
    Console.WriteLine($"Triangle area:{string.Format("{0:0.000}",circle.Area)}");
}