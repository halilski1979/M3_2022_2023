using System;
using System.Collections.Generic;
using System.Text;

namespace _05_w_Problem3_SuroviDanni
{
   public class Tyres
    {
        private int age;
        private double nalqgane;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Nalqgane
        {
            get { return nalqgane; }
            set { nalqgane = value; }
        }

        public Tyres(double nalqgane, int age)
        {
            this.nalqgane = nalqgane;
            this.age = age;
        }
    }
}
