using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Linear_And_Binary_Search
{
    internal class SearchNegativeNumber
    {
        public void DisplayNegativeNumber()
        {
            Console.WriteLine("Enter the Length of an Array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine("The Number at " + i + "index is negative and the number is " + arr[i]);
                }
            }
        }
    }
}
