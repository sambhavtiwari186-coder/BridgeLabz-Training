using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.Level_01
{
    internal class Formatexception
    {
        public void DemonstrateFormatException()
        {
            try
            {
                // Take the Input From the User
                Console.WriteLine("Enter The String Here");
                string  input = Console.ReadLine();
                // This line causes FormatException
                int number = int.Parse(input);
                Console.WriteLine(number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException caught!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
