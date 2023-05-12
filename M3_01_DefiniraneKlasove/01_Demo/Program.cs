using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Ivan";
            p.Age = 23;

            Console.WriteLine($"My name is {p.Name}. I am {p.Age} years old.");
        }
    }
}
