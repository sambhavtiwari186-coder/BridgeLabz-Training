using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extra_csharp_strings.Level_01
{
    internal class ConsonentAndVowels
    {
        static void ConsAndVowels()
        {
            Console.WriteLine("Enter a string:");
            string text = Console.ReadLine().ToLower();
            int VowelCount = 0;
            int ConsonantCount = 0;
            foreach (char ch in text)
            {
                // Check if character is an alphabet
                if (ch >= 'a' && ch <= 'z')
                {
                    // Check for vowels
                    if (ch == 'a' || ch == 'e' || ch == 'i' ||
                        ch == 'o' || ch == 'u')
                    {
                        VowelCount++;
                    }
                    else
                    {
                        ConsonantCount++;
                    }
                }
            }
            Console.WriteLine("\nNumber of Vowels: " + VowelCount);
            Console.WriteLine("Number of Consonants: " + ConsonantCount);
        }
    }
}
