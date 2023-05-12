using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_w_Problem3_Employe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employe> employes = new List<Employe>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ').ToList();
                
                Employe e = new Employe();
                e.Email = "n/a";
                e.Age = -1;
                e.Name = line[0];
                e.Salary = double.Parse(line[1]);
                e.Position = line[2];
                e.Department = line[3];

                if (line.Count==6)
                {
                    e.Email = line[4];
                    e.Age = int.Parse(line[5]);
                }

                if (line.Count==5)
                {
                    if (int.TryParse(line[4],out int result))
                    {
                        e.Age = result;
                    }
                    else
                    {
                        e.Email = line[4];
                    }
                }



                employes.Add(e);
            }
            Console.WriteLine("=================================");

            foreach (var item in employes)
            {
                Console.WriteLine($"{item.Name} {item.Salary} {item.Position} {item.Department} " +
                    $"{item.Email} {item.Age}");
            }
            
            Console.WriteLine("=================================");
            //Групиране и сортиране
            var newDep = employes.GroupBy(x=>x.Department).OrderBy(x => x.ToList().Average(y=>y.Salary));

        
            //Взимаме името на отдела с най-висока средна заплата
            var topDepartment = newDep.Last().Key;
            Console.WriteLine($"Highest Average Salary: {topDepartment}");
            foreach (var item in employes.OrderByDescending(x=>x.Salary))
            {
                if (item.Department==topDepartment)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
