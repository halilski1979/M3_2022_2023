using System;

namespace _12_w1_Person_with_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Ivan = new Person("Ivan", 23);
            Console.WriteLine(Person.Counter);

            Person Peter = new Person("Peter", 42);
            Console.WriteLine(Person.Counter);
        }
    }
}
