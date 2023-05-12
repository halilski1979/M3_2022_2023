using System;

namespace _12_w2_Geometry_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Square
            Console.Write("Square Side A = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area = {Geometry.SquareArea(a)}");
            Console.WriteLine($"Perimeter = {Geometry.SquarePerimeter(a)}");

            // Rectangle
            Console.Write("Rectangle Side A = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Rectangle Side B = ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area = {Geometry.RectangleArea(b, c)}");
            Console.WriteLine($"Perimeter = {Geometry.RectanglePerimeter(b, c)}");

            // Circle
            Console.Write("Circle Radius = ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area = {Geometry.CircleArea(r):f2}");
        }
    }
}
