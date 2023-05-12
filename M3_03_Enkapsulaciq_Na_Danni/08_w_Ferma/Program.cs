using System;

namespace _08_w_Ferma
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Input
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            // Chicken
            Chicken chicken = new Chicken(name, age);

            // Print
            Console.WriteLine(chicken.CalculateProductPerDay());
        }
    }
}
