using System;

namespace _02_w_Problem3_Area_Box
{
    class Program
    {
        static void Main(string[] args)
        {
            float lenght = float.Parse(Console.ReadLine());
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            Box box = new Box(lenght,width,height);

            Console.WriteLine($"Surface Area – {box.SurfaceArea():f2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
            Console.WriteLine($"Volume - {box.Volume():f2}");
        }
    }
}
