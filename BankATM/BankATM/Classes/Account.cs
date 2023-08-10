    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankATM.Classes
{
    public enum AccountType
    {
        Savings,
        Checking,
        Business
    }
    public class Account
    {
        public AccountType Type { get; set; }

        public decimal Balance { get; set; } = 105;
        public bool debt { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Successfully deposited {amount}. New balance is {Balance}.");
            }
            {
                Console.WriteLine("Depsoit amount must be positive");

            }

        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    Console.WriteLine($"Successfully withdrew {amount}. New balance is {Balance}.");
                }
                else
                {
                    Console.WriteLine("Insufficient balance for this withdrawal.");
                }
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }

        public void CheckBalance(decimal amount)
        {
            Console.WriteLine(Balance);
        }


    }
}
