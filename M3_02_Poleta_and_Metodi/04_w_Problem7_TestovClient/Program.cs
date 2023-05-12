using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_w_Problem7_TestovClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

            while (true)
            {
                var line = Console.ReadLine().Split(' ').ToList();
                var cmd = line[0];

                if (line[0] == "End")
                {
                    break;
                }
                if (line[0] == "Create")
                {
                    var id = int.Parse(line[1]);

                    if (accounts.ContainsKey(id))
                    {
                        Console.WriteLine("Account already exists.");
                    }
                    else
                    {
                        BankAccount acc = new BankAccount();
                        acc.ID = id;
                        accounts.Add(id, acc);
                    }
                }

                if (line[0] == "Deposit")
                {
                    var id = int.Parse(line[1]);
                    var suma = double.Parse(line[2]);
                    if (accounts.ContainsKey(int.Parse(line[1])))
                    {
                        accounts[id].Deposit(suma);
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                }

                if (line[0] == "Withdraw")
                {
                    var id = int.Parse(line[1]);
                    var suma = double.Parse(line[2]);
                    if (accounts.ContainsKey(id))
                    {
                        accounts[id].Withdraw(suma);
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                }

                if (line[0] == "Print")
                {
                    var id = int.Parse(line[1]);
                   
                    if (accounts.ContainsKey(id))
                    {
                        accounts[id].Print();
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                }


            }
        }
    }
    
}
