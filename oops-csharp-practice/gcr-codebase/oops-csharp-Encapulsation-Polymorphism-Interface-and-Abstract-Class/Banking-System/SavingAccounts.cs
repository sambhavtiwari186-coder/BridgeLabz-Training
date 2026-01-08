using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Encapulsation_Polymorphism.banking_system
{
    internal class SavingAccounts
    {
        public SavingsAccount(string accNo, string name, double balance)
            : base(accNo, name, balance)
        {
        }

        public override double CalculateInterest()
        {
            return Balance * 0.04;
        }
    }
}
