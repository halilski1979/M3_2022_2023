using System;

namespace _05_w_Problem2_Person_DefaultNameAge_Construktor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine(p1);

            Person p2 = new Person(25);
            Console.WriteLine(p2);
        }
    }
}
