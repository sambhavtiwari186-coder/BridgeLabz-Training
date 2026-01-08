using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Encapulsation_Polymorphism.banking_system
{
    internal class LoanUtility
    {
        private string LoanId = "LN-9001";

        public void ApplyForLoan(BankAccount account)
        {
            Console.WriteLine($"Loan applied for {account.AccountNumber}");
        }

        public double CalculateLoanEligibility(BankAccount account)
        {
            return account.Balance * 5;
        }
    }
}
