using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.Level_01
{
    internal class UpperCase
    {
        // Method to convert string to uppercase using ASCII logic
        static string ToUpperUsingASCII(string input)
        {
            char[] res = input.ToCharArray();

            for (int i = 0; i < res.Length; i++)
            {
                // Check if character is lowercase letter
                if (res[i] >= 'a' && res[i] <= 'z')
                {
                    res[i] = (char)(res[i] - 32);
                }
            }
            return new string(res);
        }
        public  void Conversion()
        {
            Console.WriteLine("Enter a text:");
            string UserInput = Console.ReadLine();
            string AsciiUpper = ToUpperUsingASCII(UserInput);
            string builtInUpper = UserInput.ToUpper();
            Console.WriteLine("\nUppercase using ASCII logic: " + AsciiUpper);
            Console.WriteLine("Uppercase using ToUpper():  " + builtInUpper);
        }
    }
}
