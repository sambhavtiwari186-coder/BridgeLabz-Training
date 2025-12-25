using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeLabzTraining.Methods.Level_03
{
    internal class NumberChecker2
    {
            static void Checker(string[] args)
            {
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                //  Count digits
                int count = CountDigits(number);
                Console.WriteLine("Number of Digits: " + count);
               //  Store digits in array
                int[] digits = StoreDigits(number, count);
                Console.WriteLine("Digits:");
                foreach (int d in digits)
                {
                    Console.Write(d + " ");
                }
                Console.WriteLine();
              //  Sum of digits
                int sum = SumOfDigits(digits);
                Console.WriteLine("Sum of Digits: " + sum);
                //  Sum of squares of digits
                int sumSquares = SumOfSquaresOfDigits(digits);
                Console.WriteLine("Sum of Squares of Digits: " + sumSquares);
                //  Harshad number check
                Console.WriteLine("Is Harshad Number: " + IsHarshadNumber(number, digits));
                //  Digit frequency
                int[,] frequency = DigitFrequency(digits);
                Console.WriteLine("Digit Frequency:");
                Console.WriteLine("Digit  Frequency");
                for (int i = 0; i < frequency.GetLength(0); i++)
                {
                    if (frequency[i, 1] > 0)
                    {
                        Console.WriteLine("  " + frequency[i, 0] + "       " + frequency[i, 1]);
                    }
                }
            }
          // Method to count digits
            static int CountDigits(int number)
            {
                int count = 0;
                while (number != 0)
                {
                    count++;
                    number /= 10;
                }
                return count;
            }
             //  Method to store digits in array
            static int[] StoreDigits(int number, int count)
            {
                int[] digits = new int[count];
                for (int i = count - 1; i >= 0; i--)
                {
                    digits[i] = number % 10;
                    number /= 10;
                }
                return digits;
            }
          //  Method to find sum of digits
            static int SumOfDigits(int[] digits)
            {
                int sum = 0;
                foreach (int d in digits)
                {
                    sum += d;
                }
                return sum;
            }
           //  Method to find sum of squares of digits
            static int SumOfSquaresOfDigits(int[] digits)
            {
                int sum = 0;
                foreach (int d in digits)
                {
                    sum += (int)Math.Pow(d, 2);
                }
                return sum;
            }
           //  Method to check Harshad number
            static bool IsHarshadNumber(int number, int[] digits)
            {
                int sum = SumOfDigits(digits);
                return number % sum == 0;
            }
            //  Method to find digit frequency using 2D array
            static int[,] DigitFrequency(int[] digits)
            {
                int[,] freq = new int[10, 2];
                // Initialize digits column
                for (int i = 0; i < 10; i++)
                {
                    freq[i, 0] = i;
                }
                // Count frequency
                foreach (int d in digits)
                {
                    freq[d, 1]++;
                }
                return freq;
            }
        }
    }

