using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_w_Problem1_Person_Constructors
{
   public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

        
        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
            this.Accounts = new List<BankAccount>();
        }
        
        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.Name = name;
            this.Age = age;
            this.Accounts = accounts;
        }

        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
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

        public double GetBalance()
        {
            return accounts.Sum(x => x.Balance);
        }
        public void IntroduceYourSelf()
        {
            Console.WriteLine($"{Name} {Age}");
        }
    }
}
