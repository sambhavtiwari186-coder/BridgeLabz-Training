using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.Level01
{
    internal class SumOfNaturalNumber
    {
        public void CalSum() {
            //Getting input from the user
            Console.Write("Enter a natural number: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            int ans = Sum(Number);//Calling the method
            Console.WriteLine("The sum is " + ans);
        }
           //The method for calculating the sum
         public static int Sum(int num)
        {
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                sum = sum + i;
            }

            return sum;
        }
    }
 }

