using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Extra_Built_In_Function.Level_01
{
    internal class DateComparison
    {
        public void DateCompare()
        {
            Console.WriteLine("Enter first date (yyyy-mm-dd):");
            DateTime date1 = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter second date (yyyy-mm-dd):");
            DateTime date2 = Convert.ToDateTime(Console.ReadLine());

            int result = DateTime.Compare(date1, date2);

            if (result < 0)
            {
                Console.WriteLine("\nFirst date is BEFORE the second date.");
            }
            else if (result > 0)
            {
                Console.WriteLine("First date is AFTER the second date.");
            }
            else
            {
                Console.WriteLine("Both dates are the SAME.");
            }
        }
    }
}
