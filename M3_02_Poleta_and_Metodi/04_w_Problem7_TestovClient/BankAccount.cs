using System;
using System.Collections.Generic;
using System.Text;

namespace _04_w_Problem7_TestovClient
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
            if (amount>this.Balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                this.Balance -= amount;
            }
           
        }

        public override string ToString()
        {
            return $"ID {this.ID} => {this.Balance} lv.";

        }

        public void Print()
        {
            Console.WriteLine($"AccountID {this.ID} => Ballance {this.Balance:f2}");
        }



    }
}
