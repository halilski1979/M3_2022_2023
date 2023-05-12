using System;

namespace _09_w_2_BoxValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            float lenght = float.Parse(Console.ReadLine());
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());

            Box box = new Box(lenght, width, height);

            Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
            Console.WriteLine($"Volume - {box.Volume():f2}");
        }
    }
}
