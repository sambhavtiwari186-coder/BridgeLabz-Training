
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Array.Level__2
{
    internal class LargestTwo
    {
        public void LargestTwoCal() {
            //taking inout from the user
            long num = Convert.ToInt64(Console.ReadLine());
            int MaxDigit = 10;
            int[] arr = new int[MaxDigit];
            int a = 0;
            while (num > 0)
            {
               if (a == MaxDigit){
                    //creating a new array if size excedded
                    MaxDigit += 10;
                    int[] temp = new int[MaxDigit];
                    for (int j = 0; j < temp.Length - 10; j++)
                    {
                        temp[j] = arr[j];
                    }
                    arr = temp;
                }
                arr[a] = Convert.ToInt32(num % 10);
                num /= 10;
                a++;
            }
            int Largest = arr[0];
            int SecondLargest = 0;
             //applying logic to find largest and second largest 
            for (int i = 1; i < 10; i++)
            {
                if (arr[i] > Largest)
                {
                    SecondLargest = Largest;
                    Largest = arr[i];

                }
                else if (arr[i] > SecondLargest && arr[i] < Largest)
                {
                    SecondLargest = arr[i];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"Largest Element {Largest}");
            Console.WriteLine($"Second Largest Element {SecondLargest}");
        }
    }
}
