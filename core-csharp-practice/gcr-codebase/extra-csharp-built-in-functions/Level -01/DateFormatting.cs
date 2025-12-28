using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Extra_Built_In_Function.Level_01
{
    internal class DateFormatting
    {
        public void DateFormat()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Current Date in Different Formats:\n");
            // Format: dd/MM/yyyy
            Console.WriteLine("dd/MM/yyyy      : " + today.ToString("dd/MM/yyyy"));
            // Format: yyyy-MM-dd
            Console.WriteLine("yyyy-MM-dd      : " + today.ToString("yyyy-MM-dd"));
            // Format: EEE, MMM dd, yyyy
            Console.WriteLine("EEE, MMM dd, yyyy: " + today.ToString("ddd, MMM dd, yyyy"));
        }
    }
}
