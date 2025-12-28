using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.Level_01
{
    internal class LowerCase
    {
        // Method to convert string to uppercase using ASCII logic
        static string ToLowerUsingASCII(string input)
        {
            char[] Result = input.ToCharArray();
            for (int i = 0; i < Result.Length; i++)
            {
                // Check if character is Uppercase letter
                if (Result[i] >= 'A' && Result[i] <= 'Z')
                {
                    Result[i] = (char)(Result[i] + 32);
                }
            }
            return new string(Result);
        }
        public void Conversion()
        {
            Console.WriteLine("Enter a text:");
            string UserInput = Console.ReadLine();
            string AsciiLower = ToLowerUsingASCII(UserInput);
            string builtInLower = UserInput.ToLower();
            Console.WriteLine("\nUppercase using ASCII logic: " + AsciiLower);
            Console.WriteLine("Uppercase using ToUpper():  " + builtInLower);
        }
    }
}
