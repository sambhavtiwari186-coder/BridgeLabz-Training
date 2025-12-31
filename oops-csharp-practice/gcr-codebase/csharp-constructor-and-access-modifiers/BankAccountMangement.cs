using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class BankAccountMangement
    {
        // Base Class
        public  class BankAccount
        {
            // Access Modifiers
            public int accountNumber;          // Accessible everywhere
            protected string accountHolder;    // Accessible in derived class
            private double balance;             // Accessible only within BankAccount

            // Constructor
            public BankAccount(int accountNumber, string accountHolder, double balance)
            {
                this.accountNumber = accountNumber;
                this.accountHolder = accountHolder;
                this.balance = balance;
            }

            // Getter for balance
            public double GetBalance()
            {
                return balance;
            }

            // Setter / Modifier for balance
            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                }
                else
                {
                    Console.WriteLine("Invalid deposit amount");
                }
            }

            public void Withdraw(double amount)
            {
                if (amount > 0 && amount <= balance)
                {
                    balance -= amount;
                }
                else
                {
                    Console.WriteLine("Invalid or insufficient balance");
                }
            }

            // Display basic account details
            public void DisplayAccount()
            {
                Console.WriteLine("Account Number : " + accountNumber);
                Console.WriteLine("Account Holder : " + accountHolder);
                Console.WriteLine("Balance        : ₹" + balance);
            }
        }

        // Derived Class
        internal class SavingsAccount : BankAccount
        {
            private double interestRate;

            public SavingsAccount(int accountNumber, string accountHolder, double balance, double interestRate)
                : base(accountNumber, accountHolder, balance)
            {
                this.interestRate = interestRate;
            }

            // Accessing public and protected members
            public void DisplaySavingsAccount()
            {
                Console.WriteLine("Savings Account Details");
                Console.WriteLine("Account Number : " + accountNumber);   // public access
                Console.WriteLine("Account Holder : " + accountHolder);   // protected access
                Console.WriteLine("Interest Rate  : " + interestRate + "%");
                Console.WriteLine("Balance        : ₹" + GetBalance());
            }
        }

        // Display Class
        internal class Program
        {
            public static void Display()
            {
                BankAccount acc = new BankAccount(1001, "Rahul Sharma", 5000);
                acc.DisplayAccount();

                Console.WriteLine();

                acc.Deposit(2000);
                acc.Withdraw(1500);
                Console.WriteLine("Updated Balance : ₹" + acc.GetBalance());

                Console.WriteLine();

                SavingsAccount sa = new SavingsAccount(2001, "Neha Verma", 10000, 4.5);
                sa.DisplaySavingsAccount();
            }
        }
    }

}
