using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.Level01
{
    internal class SmallestAndLargest
    {
        public void SamllestAndLargest() {
            //Getting input from user
            Console.Write("Enter first number: ");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int Number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int Number3 = Convert.ToInt32(Console.ReadLine());
            int[] resultArr = FindSmallestAndLargest(Number1, Number2, Number3);//Calling the method
            Console.WriteLine("Smallest number is: " + resultArr[0]);
            Console.WriteLine("Largest number is: " + resultArr[1]);
        }
         public static int[] FindSmallestAndLargest(int n1, int n2, int n3)
        {
            int smallestNum = n1;
            int largestNum = n1;

            if (n2 < smallestNum) smallestNum = n2;
            if (n3 < smallestNum) smallestNum = n3;
            if (n2 > largestNum) largestNum = n2;
            if (n3 > largestNum) largestNum = n3;

            return new int[] { smallestNum, largestNum };
        }
    }
}
