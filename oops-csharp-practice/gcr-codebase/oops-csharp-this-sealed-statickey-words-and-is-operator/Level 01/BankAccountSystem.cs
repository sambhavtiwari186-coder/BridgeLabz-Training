using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.keywords_and_instances_in_oops
{
    internal class BankAccountSystem
    {
        class BankAccount
        {
            // static variable shared across all accounts
            public static string bankName = "State Bank of India";
            private static int totalAccounts = 0;

            // readonly variable (cannot be changed once assigned)
            public readonly int AccountNumber;
            public string AccountHolderName;

            // Constructor using 'this' keyword
            public BankAccount(string AccountHolderName, int AccountNumber)
            {
                this.AccountHolderName = AccountHolderName;
                this.AccountNumber = AccountNumber;

                totalAccounts++;

            }
            public static void GetTotalAccounts()
            {
                Console.WriteLine("Total Accounts Created: " + totalAccounts);
            }

            // Method to display account details
            public void DisplayDetails()
            {
                Console.WriteLine("Bank Name: " + bankName);
                Console.WriteLine("Account Holder Name: " + AccountHolderName);
                Console.WriteLine("Account Number: " + AccountNumber);
            }
        }
    }
}
