using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Array.Level__2
{
    internal class FrequencyOfNumber
    {
        public void FrequencyOfNumberCal()
        {
            // Taking number as input from user
            Console.WriteLine("Enter The Number Here :: ");
            int a = Convert.ToInt32(Console.ReadLine());
            // To store digits
            int[] arr = new int[10];
            int index = 0;
            while (a > 0)
            {
                int rem = a % 10;
                arr[index] = rem;
                a = a / 10;
                index++;
            }
            // Array to store frequency
            int[] freq= new int[index];
            for (int i = 0; i < index; i++)
            {
                // Skip already counted digits
                bool AlreadyCounted = false;
                for (int k = 0; k < i; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        AlreadyCounted = true;
                        break;
                    }
                }
                if (AlreadyCounted)
                    continue;
                int count = 0;
                for (int j = 0; j < index; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                freq[i] = count;
                Console.WriteLine("The digit " + arr[i] + " has been repeated " + freq[i] + " times");
            }
        }
    }
}
