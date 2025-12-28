using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Extra_Built_In_Function.Level_02
{
    internal class PalindromeChecker
    {
        public void Checker()
        {
            string input = GetInput();
            bool IsPalindrome = CheckPalindrome(input);
            DisplayResult(input, IsPalindrome);
        }
        // Method to take string input
        public  string GetInput()
        {
            Console.WriteLine("Enter a string:");
            return Console.ReadLine();
        }
        // Method to check palindrome condition
        public  bool CheckPalindrome(string text)
        {
            int left = 0;
            int right = text.Length - 1;
            while (left < right)
            {
                // Ignore spaces and case
                if (text[left] == ' ')
                {
                    left++;
                    continue;
                }
                if (text[right] == ' ')
                {
                    right--;
                    continue;
                }
                if (char.ToLower(text[left]) != char.ToLower(text[right]))
                    return false;
                left++;
                right--;
            }
            return true;
        }
        // Method to display result
        public  void DisplayResult(string text, bool res)
        {
            if (res)
                Console.WriteLine($"\"{text}\" is a Palindrome.");
            else
                Console.WriteLine($"\"{text}\" is NOT a Palindrome.");
        }
    }
}
