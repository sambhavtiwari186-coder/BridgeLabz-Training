using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabzTraining.Methods.Level_03
{
    internal class NumberChecker3
    {
        static void Checker(string[] args)
            {
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
              // Count digits
                int count = CountDigits(number);
                Console.WriteLine("Count of digits: " + count);
                //  Store digits
                int[] digits = StoreDigits(number, count);
                Console.WriteLine("Digits:");
                PrintArray(digits);
                //  Reverse digits array
                int[] reversedDigits = ReverseArray(digits);
                Console.WriteLine("Reversed Digits:");
                PrintArray(reversedDigits);
                //  Compare arrays
                Console.WriteLine("Digits and Reversed Digits are Equal: " +
                                  AreArraysEqual(digits, reversedDigits));
            //  Palindrome check
            Console.WriteLine("Is Palindrome Number: " +
                              IsPalindrome(digits, reversedDigits);
                // Duck number check
                Console.WriteLine("Is Duck Number: " +
                                  IsDuckNumber(digits));
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
           // Method to store digits in array
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
           //  Method to reverse digits array
            static int[] ReverseArray(int[] digits)
            {
                int[] reversed = new int[digits.Length];
                int index = 0;

                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    reversed[index++] = digits[i];
                }

                return reversed;
            }
           //  Method to compare two arrays
            static bool AreArraysEqual(int[] arr1, int[] arr2)
            {
                if (arr1.Length != arr2.Length)
                    return false;

                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                        return false;
                }
                return true;
            }
              //  Method to check palindrome number
            static bool IsPalindrome(int[] digits, int[] reversedDigits)
            {
                return AreArraysEqual(digits, reversedDigits);
            }
        // Method to check duck number
            static bool IsDuckNumber(int[] digits)
            {
                foreach (int d in digits)
                {
                    if (d != 0)
                        return true;
                }
                return false;
            }
            // Helper method to print array
            static void PrintArray(int[] arr)
            {
                foreach (int x in arr)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
        }
    }
