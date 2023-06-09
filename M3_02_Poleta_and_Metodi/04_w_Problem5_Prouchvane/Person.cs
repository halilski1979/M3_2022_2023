﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04_w_Problem5_Prouchvane
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
            return $" {this.Name} - {this.Age}";
        }
    }
}
