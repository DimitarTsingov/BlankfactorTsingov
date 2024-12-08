using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 2 - Bank Account Class

namespace Lecture7
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }

    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance >= 0 ? initialBalance : throw new ArgumentException("Initial balance cannot be negative.");
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be greater than zero.");
            }
            Balance += amount;
            Console.WriteLine($"Successfully deposited {amount}. New balance: {Balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero.");
            }

            if (amount > Balance)
            {
                throw new InsufficientFundsException($"Insufficient funds. Your balance is {Balance}, but you tried to withdraw {amount}.");
            }

            Balance -= amount;
            Console.WriteLine($"Successfully withdrew {amount}. New balance: {Balance}");
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }

    public class Task2
    {
        public void Run()
        {
            try
            {
                Console.Write("Enter account number: ");
                string accountNumber = Console.ReadLine();

                decimal initialBalance;
                while (true)
                {
                    Console.Write("Enter initial balance: ");
                    if (decimal.TryParse(Console.ReadLine(), out initialBalance) && initialBalance >= 0)
                        break;
                    Console.WriteLine("Invalid input. Initial balance must be a non-negative decimal value.");
                }

                BankAccount account = new BankAccount(accountNumber, initialBalance);

                while (true)
                {
                    Console.WriteLine("\nChoose an option:");
                    Console.WriteLine("1. Display Account Info");
                    Console.WriteLine("2. Deposit Funds");
                    Console.WriteLine("3. Withdraw Funds");
                    Console.WriteLine("4. Exit");

                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        account.DisplayAccountInfo();
                    }
                    else if (choice == "2")
                    {
                        decimal depositAmount;
                        while (true)
                        {
                            Console.Write("Enter amount to deposit: ");
                            if (decimal.TryParse(Console.ReadLine(), out depositAmount) && depositAmount > 0)
                                break;
                            Console.WriteLine("Invalid input. Deposit amount must be greater than zero.");
                        }

                        account.Deposit(depositAmount);
                    }
                    else if (choice == "3")
                    {
                        decimal withdrawalAmount;
                        while (true)
                        {
                            Console.Write("Enter amount to withdraw: ");
                            if (decimal.TryParse(Console.ReadLine(), out withdrawalAmount) && withdrawalAmount > 0)
                                break;
                            Console.WriteLine("Invalid input. Withdrawal amount must be greater than zero.");
                        }

                        try
                        {
                            account.Withdraw(withdrawalAmount);
                        }
                        catch (InsufficientFundsException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                    else if (choice == "4")
                    {
                        Console.WriteLine("Exiting. Goodbye!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
