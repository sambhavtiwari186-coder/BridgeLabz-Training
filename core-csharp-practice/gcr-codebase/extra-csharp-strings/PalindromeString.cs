using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extra_csharp_strings.Level_01
{
    internal class PalindromeString
    {
        public  void PalinString()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();
            if (s == null)
                return;
            s = s.ToLower();   
            int l = 0;
            int r = s.Length - 1;
            bool isPalindromeString = true;
            while (l < r)
            {
                if (s[l] != s[r])
                {
                    isPalindromeString = false;
                    break;
                }
                l++;
                r--;
            }
            if (isPalindromeString)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not a Palindrome");
        }
    }
}
    
