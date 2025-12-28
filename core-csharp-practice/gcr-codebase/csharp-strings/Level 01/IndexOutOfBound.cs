 using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.Level_01
{
    internal class IndexOutOfBound
    {
        static void Index()
        {
            GenerateException();
            HandleException();
        }
        // Method that causes IndexOutOfRangeException
        public static void GenerateException()
        {
            string a = Console.ReadLine();
            Console.WriteLine(a[10]);
        }
        // Method that handles IndexOutOfRangeException
        public static void HandleException()
        {
            try
            {
                string word = "DotNet";
                Console.WriteLine(word[8]); 
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException caught!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}

