using System;

namespace BridgeLabzTraining.Array.Level__2
{
    internal class LargestAndSecondLargest{
        public void LargestAndSecondLargestCal() {
            int[] arr = new int[10];
            int index = 0;
            Console.WriteLine("Enter the number:");
            int a = Convert.ToInt32(Console.ReadLine());
           // Extract digits and store in array
            while (a > 0){
                int rem = a % 10;
                arr[index] = rem;
                a = a / 10;
                index++;
            }
            int Max = arr[0];
            int SecondMax = 0;
            // Find largest and second largest
            for (int i = 1; i < index; i++)
            {
                if (arr[i] > Max)
                {
                    SecondMax = Max;
                    Max = arr[i];
                }
                else if (arr[i] != Max && arr[i] > SecondMax)
                {
                    SecondMax = arr[i];
                }
            }
            Console.WriteLine("Largest digit: " + Max);
            Console.WriteLine("Second largest digit: " + SecondMax);
        }
    }
}
