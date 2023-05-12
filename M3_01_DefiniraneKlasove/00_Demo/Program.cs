using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "Ivan";
            p.age = 25;

            Console.WriteLine($"My name is {p.name}. I am {p.age} old.");
        }
    }
}
