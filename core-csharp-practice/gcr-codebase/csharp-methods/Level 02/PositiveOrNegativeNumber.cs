using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level2
{
    internal class PositiveOrNegativeNumber
    {
        public static void PositiveAndNegativeFn()
        {
            int[] NumArray = new int[5];
            //Getting input from user
            Console.Write("Enter numbers:");
            for (int i = 0; i < NumArray.Length; i++)
            {
                NumArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Uisng and calling Methods
            for (int i = 0; i < NumArray.Length; i++)
            {
                if (PositiveCheck(NumArray[i]))
                {
                    Console.Write(NumArray[i] + " is Positive and ");
                    if (EvenCheck(NumArray[i])) Console.WriteLine("Even");
                    else Console.WriteLine("Odd");
                }
                else
                {
                    Console.WriteLine(NumArray[i] + " is Negative");
                }
            }
            int Answer = ComparingFunction(NumArray[0], NumArray[NumArray.Length - 1]);
            if (Answer == 1) Console.WriteLine("First element is greater than last element");
            else if (Answer == 0) Console.WriteLine("First and last elements are equal");
            else Console.WriteLine("First element is less than last element");

        }
        public static int ComparingFunction(int num1, int num2)
        {
            if (num1 > num2) return 1;
            else if (num1 == num2) return 0;
            else return -1;
        }
        //Method to check positive or negative
        public static bool PositiveCheck(int num)
        {
            if (num >= 0) return true;
            return false;
        }
        //Method to check even or odd
        public static bool EvenCheck(int num)
        {
            if (num % 2 == 0) return true;
            return false;
        }
    }
}