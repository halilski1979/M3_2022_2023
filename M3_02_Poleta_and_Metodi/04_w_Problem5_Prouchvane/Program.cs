using System;
using System.Linq;

namespace _04_w_Problem5_Prouchvane
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            People peoples = new People();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ').ToList();
                Person p = new Person();
                p.Name = line[0];
                p.Age = int.Parse(line[1]);
                peoples.AddPerson(p);
            }

            peoples.SortName_Above30();


        }
    }
}
