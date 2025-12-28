using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Extra_Built_In_Function.Level_02
{
    internal class PrimeNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int Number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = CheckPrime(Number);
            if (isPrime)
            {
                Console.WriteLine(Number + " is a Prime Number.");
            }
            else
            {
                Console.WriteLine(Number + " is NOT a Prime Number.");
            }
        }
        // Method to check whether a number is prime
        static bool CheckPrime(int num)
        {
            if (num <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
