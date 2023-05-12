using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_w_Problem1_BancAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            acc.ID = 1;
            acc.Balance = 1000;
            Console.WriteLine($"Bankova smetka №{acc.ID} => {acc.Balance} lv.");
        }
    }
}
