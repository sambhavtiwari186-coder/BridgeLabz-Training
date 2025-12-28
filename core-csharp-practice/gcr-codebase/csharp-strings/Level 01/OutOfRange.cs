using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.Level_01
{
    internal class OutOfRange
    {
        public void DemonstrateException()
        {
            try
            {
                Console.WriteLine("Enter The String Here");
                string text = Console.ReadLine();
                string result = text.Substring(text.Length, text.Length);
                Console.WriteLine(result);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("ArgumentOutOfRangeException caught!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
