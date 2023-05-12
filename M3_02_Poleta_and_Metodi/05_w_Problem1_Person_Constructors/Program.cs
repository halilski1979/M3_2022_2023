using System;
using System.Collections.Generic;

namespace _05_w_Problem1_Person_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<BankAccount> acc = new List<BankAccount>(); // <=  списък от банкови акаунти
            BankAccount ac1 = new BankAccount();             // <=  oбект от клас BankAccount
            
            ac1.ID = 1;
            ac1.Balance = 100;
            acc.Add(ac1);

            BankAccount ac2 = new BankAccount();
            ac2.ID = 2;
            ac2.Balance = 200;
            acc.Add(ac2);

            BankAccount ac3 = new BankAccount();
            ac3.ID = 3;
            ac3.Balance = 300;
            acc.Add(ac3);

            Person p = new Person("Ivan", 23,acc);

            //Console.WriteLine($"Total sum: {p.GetBalance()} lv.");
        
            foreach (var item in acc)
            {                
                Console.WriteLine($"{p.Name} => ID {item.ID} :{item.Balance}");
            }
            Console.WriteLine($"Total balance: {p.GetBalance()} lv.");


        }
    }
}
