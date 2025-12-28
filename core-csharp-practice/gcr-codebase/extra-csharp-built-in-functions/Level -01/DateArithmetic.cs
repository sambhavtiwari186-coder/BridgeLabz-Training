using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Extra_Built_In_Function.Level_01
{
    internal class DateArithmetic
    {
        public void Main()
        {
            Console.WriteLine("Enter a date (yyyy-mm-dd):");
            DateTime InputDate = Convert.ToDateTime(Console.ReadLine());
            // Add 7 days
            DateTime ResultDate = InputDate.AddDays(7);
            // Add 1 month
            ResultDate = ResultDate.AddMonths(1);
            // Add 2 years
            ResultDate = ResultDate.AddYears(2);
            // Subtract 3 weeks (3 × 7 = 21 days)
            ResultDate = ResultDate.AddDays(-21);
            Console.WriteLine("\nFinal Date after calculations:");
            Console.WriteLine(ResultDate.ToShortDateString());
        }
    }
}
