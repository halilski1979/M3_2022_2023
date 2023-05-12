using System;
using System.Collections.Generic;
using System.Text;

namespace _09_w_3_NaPazar
{
    public class Product
    {
        // Име
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                //Името не може да бъде празен низ
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        // Стойност
        private float price;
        public float Price
        {
            get { return price; }
            set
            {
                //Парите не може да бъдат отрицателно число.
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }
                price = value;
            }
        }
        // Конструктор
        public Product(string name, float price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
