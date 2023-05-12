using System;
using System.Collections.Generic;
using System.Linq;


namespace _02_w_Problem2_Sortirane_Name_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ').ToList();
                Person p = new Person(line[0],line[1],int.Parse(line[2]));
                persons.Add(p);
            }

            persons = persons.OrderBy(x => x.firtsName).ThenBy(y => y.age).ToList();
            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }

        }
    }
}
