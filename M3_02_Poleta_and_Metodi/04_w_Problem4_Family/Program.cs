using System;
using System.Linq;

namespace _04_w_Problem4_Family
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family ivanovi = new Family();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ').ToList();
                Person p = new Person();
                p.Name = line[0];
                p.Age = int.Parse(line[1]);
                ivanovi.AddMembers(p);
            }
            Console.WriteLine("===========PRINT===============");
            ivanovi.Print();
           
          
            Console.WriteLine("===========SORT NAME===============");
            ivanovi.SortName();

            Console.WriteLine("===========SORT AGE===============");
            ivanovi.SortAge();

            Console.WriteLine("==========Oldets Member================");
            Console.WriteLine(ivanovi.GetOldestMember());
            
        }
    }
}
