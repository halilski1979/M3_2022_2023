﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_w_Problem1_Person
{
   public  class Person
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

        public void IntroduceYourSelf()
        {
            Console.WriteLine($"{Name} {Age}");
        }

       

    }
}
