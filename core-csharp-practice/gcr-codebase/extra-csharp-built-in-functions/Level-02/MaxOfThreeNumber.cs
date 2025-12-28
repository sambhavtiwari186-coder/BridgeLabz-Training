using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Extra_Built_In_Function.Level_02
{
    internal class MaxOfThreeNumber
    {
        public void Max()
        {
            int num1 = GetInput("Enter first number:");
            int num2 = GetInput("Enter second number:");
            int num3 = GetInput("Enter third number:");
            int max = FindMaximum(num1, num2, num3);
            DisplayResult(max);
        }
        // Method to take integer input from user
        public  int GetInput(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        // Method to find maximum of three numbers
        public  int FindMaximum(int a, int b, int c)
        {
            int max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            return max;
        }

       // Method to display result
        public  void DisplayResult(int max)
        {
            Console.WriteLine("\nMaximum number is: " + max);
        }
    }
}
