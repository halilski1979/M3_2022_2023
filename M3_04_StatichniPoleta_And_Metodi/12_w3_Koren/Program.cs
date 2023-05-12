using System;

namespace _12_w3_Koren
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(SquareRoot.Sqrt(number));
                n--;
            }
        }
    }
}
