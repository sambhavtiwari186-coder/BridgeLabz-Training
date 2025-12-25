using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.Level01
{
    internal class NoOfChocolate
    {
        public void CalChocolate() {
            // Taking No of Chocolate and No of Children ad input from user
            Console.Write("Enter the number of chocolates: ");
            int Chocolates = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of children: ");
            int Children = Convert.ToInt32(Console.ReadLine());
            //Calling the method
            int[] ans = FindRemainderAndQuotient(Chocolates, Children);
            Console.WriteLine("Amount of Chocolate each child gets: " + ans[0]);
            Console.WriteLine("Remaining: " + ans[1]);
        }
        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int quotient = number / divisor;
            int remainder = number % divisor;
            return new int[] { quotient, remainder };
        }

    }
}
