using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_w_Problem3_PersonsMoney
{
   public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

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

        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public double GetBallance()
        {
            return accounts.Sum(x=>x.Balance);
        }
    }
}
