using System;
using System.Collections.Generic;
using System.Text;

namespace _02_w_Problem2_Sortirane_Name_Age
{
   public class Person
    {
        public Person(string firtsName, string lastName, int age)
        {
            this.firtsName = firtsName;
            this.lastName = lastName;
            this.age = age;
        }

        public string firtsName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        public override string ToString()
        {
            return $"{this.firtsName} {this.lastName} is a {this.age} years old"; 
        }

    }
}
