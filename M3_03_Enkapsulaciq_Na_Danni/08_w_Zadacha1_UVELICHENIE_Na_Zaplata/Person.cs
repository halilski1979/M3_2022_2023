using System;
using System.Collections.Generic;
using System.Text;

namespace _08_w_Zadacha1_UVELICHENIE_Na_Zaplata
{
    public class Person
    {
        public Person(string firtsName, string lastName, int age, double salary)
        {
            this.firtsName = firtsName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public string firtsName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public double salary { get; set; }

        public void IncreaseSalary(double bonus)
        {
            if (this.age > 30)
            {
                this.salary += this.salary * bonus / 100;
            }
            else
            {
                this.salary += this.salary * bonus / 200;
            }
        }

        public override string ToString()
        {
            return $"{this.firtsName} {this.lastName} is a {this.age} years old. Get {this.salary} lv.";
        }
    }
}
