using BankATM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BankATM
{
    public class Program
    {
        static List<User> users = new List<User>();

        static void Main(string[] args)
        {


            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("What you'd like to do today? 1 register, 2 login, 3 exit");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    RegisterUser();
                }
                else if (input == 2)
                {
                    User user = LoginUser();
                    if (user != null)
                    {
                        ShowMenu(user);
                    }
                }
                else if (input == 3)
                {
                    exit = true;
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("You gotta pick between 1, 2, or 3");
                }



            }
        }
        static void RegisterUser()
        {
            Console.WriteLine("Enter a username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter a password:");
            string password = Console.ReadLine();

            Console.WriteLine("Choose an account type: 1 for Savings, 2 for Checking, 3 for Business");
            int accountTypeChoice = Convert.ToInt32(Console.ReadLine());

            AccountType accountType = AccountType.Savings; // Default to Savings
            switch (accountTypeChoice)
            {
                case 1:
                    accountType = AccountType.Savings;
                    break;
                case 2:
                    accountType = AccountType.Savings;
                    break;
                case 3:
                    accountType = AccountType.Savings;
                    break;
                default:
                    Console.WriteLine("Invalid choice, defaulting to Savings");
                    break;
            }
            Account newAccount = new Account
            {
                Type = accountType,
                Balance = 0 // Initial balance
            };

            User newUser = new User
            {
                Username = username,
                Password = password
            };
            newUser.Accounts.Add(newAccount);

            users.Add(newUser); // Add the new user to the users list

            Console.WriteLine("User registered successfully!");
        }

        static User LoginUser()
        {
            Console.WriteLine("Username");
            string username = Console.ReadLine();
            Console.WriteLine("Password");
            string password = Console.ReadLine();

            User user = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                Console.WriteLine("Login successful!");
                return user;
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
                return null;
            }
        }
        static void ShowMenu(User user)
        {
            bool logout = false;

            while (!logout)
            {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2 Withdraw");
                Console.WriteLine("3 Check balance");
                Console.WriteLine("4 Logout ");

                int choide = Convert.ToInt32(Console.ReadLine());

                switch (choide)
                {
                    case 1:
                        Console.WriteLine("Enter Deposit amount");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        user.Accounts[0].Deposit(depositAmount); // Assuming the user has at least one account
                        break;

                        case 2:
                        Console.WriteLine("Enter withdrawal amount:");
                        decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
                        user.Accounts[0].Withdraw(withdrawalAmount);
                        break;
                    case 3:
                        Console.WriteLine($"Your balance is:{user.Accounts[0].Balance}"); // Assuming the user has at least one account
                        break;
                    case 4:
                        logout = true;
                        Console.WriteLine("Logged out successfully.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }




            }
        }

    }
}
