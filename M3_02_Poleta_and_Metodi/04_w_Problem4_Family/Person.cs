using System;
using System.Collections.Generic;
using System.Text;

namespace _04_w_Problem4_Family
{
   public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return $"Oldest member is {this.Name}, {this.Age}";
        }
    }
}
