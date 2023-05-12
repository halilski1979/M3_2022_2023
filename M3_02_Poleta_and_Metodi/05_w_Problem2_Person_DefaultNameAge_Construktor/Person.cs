using System;
using System.Collections.Generic;
using System.Text;

namespace _05_w_Problem2_Person_DefaultNameAge_Construktor
{
    public class Person
    {
        private string name;
        private int age; 
        
       
        //Конструктор без параметри
        public Person()
        {
            this.Name = "No Name";
            this.Age = 1;
        }

        public Person(int age)
        {
            this.Age = age;
            this.Name = "No Name";
        }

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
            return $"{this.Name}:  {this.Age} years.";
        }
        public void IntroduceYourSelf()
        {
            Console.WriteLine($"{Name} {Age}");
        }
    }
}
