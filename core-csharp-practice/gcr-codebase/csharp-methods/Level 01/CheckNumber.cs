using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.Level01
{
    internal class CheckNumber
    {
        public void NumberCheck() {
            //Taking  input from the user
            Console.Write("Enter an integer: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            //Calling the method
            int ans = Check(Number); 
            // Displaying result 
            if (ans == 1) Console.WriteLine("Positive");
            else if (ans == -1) Console.WriteLine("Negative");
            else Console.WriteLine("Zero");
        }
        public static int Check(int num)
        {
            if (num > 0) return 1;
            else if (num < 0) return -1;
            else return 0;
        }
    }
}
