using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BridgeLabzTraining.Methods.level2
{
    internal class LeapYearOrNOt
    {
        public static void LeapYear()
        {
            // Take input from user
            Console.Write("Enter the year: ");
            int GivenYear = Convert.ToInt32(Console.ReadLine());
             //Calling the method
            bool Answer = LeapYearChecker(GivenYear);

            if (Answer)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }
        }
           //Method for checking leap year
        public static bool LeapYearChecker(int GivenYear)
        {
            if (GivenYear < 1582)
            {
                return false;
            }
            if ((GivenYear % 4 == 0 && GivenYear % 100 != 0) || (GivenYear % 400 == 0))
            {
                return true;
            }
            return false;
        }
    }
}