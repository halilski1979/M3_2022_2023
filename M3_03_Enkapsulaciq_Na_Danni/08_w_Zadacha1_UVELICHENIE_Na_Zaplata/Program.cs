using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_w_Zadacha1_UVELICHENIE_Na_Zaplata
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
                Person p = new Person(line[0], line[1], int.Parse(line[2]),double.Parse(line[3]));
                persons.Add(p);
            }
            double bonus = double.Parse(Console.ReadLine());

            //persons = persons.OrderBy(x => x.firtsName).ThenBy(y => y.age).ToList();

            //I начин
            foreach (var item in persons)
            {
                item.IncreaseSalary(bonus);
            }
            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }
        }
    }
}
