using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.Level01
{
    internal class QuotientAndRemanider
    {
        public void CalQuotientAndRemanider() {
            //Getting input from the user
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int[] answer = FindRemainderAndQuotient(num, divisor); //Calling the method

            // Displaying  result
            Console.WriteLine("Quotient is " + answer[0]);
            Console.WriteLine("Remainder is " + answer[1]);
        }
    }
}
