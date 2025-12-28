using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.Level_01
{
    internal class NullReference
    {

        public static void DemonstrateNullReference()
        {
            try
            {
                // Giving a string a null value
                string name = null;  
                // Accessing method on null object
                int length = name.Length;
                Console.WriteLine("Length: " + length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException caught!");
                Console.WriteLine(ex.Message);
            }
        }
    }

}
