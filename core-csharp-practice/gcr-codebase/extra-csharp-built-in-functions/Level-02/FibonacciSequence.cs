using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Extra_Built_In_Function.Level_02
{
    internal class FibonacciSequence
    {
        public  void Fibonacci()
        {
            Console.WriteLine("Enter the number of terms:");
            int terms = Convert.ToInt32(Console.ReadLine());
            GenerateFibonacci(terms);
        }
        // Method to calculate and print Fibonacci sequence
        public  void GenerateFibonacci(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive number.");
                return;
            }
            int first = 0, second = 1;
            Console.WriteLine("\nFibonacci Sequence:");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(first + " ");
                int next = first + second;
                first = second;
                second = next;
            }
        }
    }
}
