﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _05_w_Problem3_SuroviDanni
{
    public class Tovar
    {
        private int weight;
        private string type;

        public Tovar(int weight,string type)
        {
            this.Weight = weight;
            this.Type = type;
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

       

        public string Type
        {
            get { return type; }
            set { type = value; }
        }


    }
}
