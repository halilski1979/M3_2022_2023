using System;
using System.Collections.Generic;
using System.Text;

namespace _05_w_Problem1_Person_Constructors
{
    public class BankAccount
    {
        private int id;
        private double balance;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }
        public void Withdraw(double amount)
        {
            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"ID {this.ID} => {this.Balance} lv.";

        }
    }
}
