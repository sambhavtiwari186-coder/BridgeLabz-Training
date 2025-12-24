using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Array.Level__2
{
    internal class ReverseOfTheNumber
    {
        public  void ReverseOfTheNumberCal() {
            // Take integer as input from the User
            Console.WriteLine("Enter The  Number Here :: ");
            int a = Convert.ToInt32(Console.ReadLine());
            // Intalise the Array
            int[] arr = new int[10];
            int index = 0;
            while (a > 0) {
                int rem = 0;
                rem = a % 10;
                arr[index]= rem;
                a = a / 10;
                index++;
            
            }
            // Printing the number in Reverse Order
            Console.WriteLine("The Number in Reverse Order is ::  ");
            for (int i = 0; i < index; i++) {
                Console.Write(arr[i]);
              
            }
        }
    }
}
