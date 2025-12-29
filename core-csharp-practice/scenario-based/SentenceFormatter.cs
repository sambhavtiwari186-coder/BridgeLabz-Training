using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BridgeLabzTraining.scenario_based.SentenceFormatter
{
    internal class SentenceFormatter {
        // Method 1: Remove leading, trailing and extra spaces
        public string RemoveExtraSpaces(string text)
        {
            // Removing leading spaces first  
            string result = "";
            bool SpaceFound = true;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    result = result + text[i];
                    SpaceFound = false;
                }
                else if (!SpaceFound)
                {
                    result = result + ' ';
                    SpaceFound = true;
                }
            }
            // Remove trailing space manually
            if (result.Length > 0 && result[result.Length - 1] == ' ')
            {
                result = result.Substring(0, result.Length - 1);
            }
            return result;
        }
        // Method 2: Ensure exactly one space after punctuation
        public string FixPunctuationSpacing(string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                result = result + text[i];
                if (text[i] == '.' || text[i] == '?' || text[i] == '!')
                {
                    if (i + 1 < text.Length && text[i + 1] != ' ')
                    {
                        result = result + ' ';
                    }
                }
            }
            return result;
        }
        // Method 3: Capitalize first letter of each sentence
        public string CapitalizeSentences(string text)
        {
            string result = "";
            bool Capitalize = true;
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (Capitalize && ch >= 'a' && ch <= 'z')
                {
                    ch = (char)(ch - 32); // convert to uppercase
                    Capitalize = false;
                }
                else if (ch >= 'A' && ch <= 'Z')
                {
                    Capitalize = false;
                }
                if (ch == '.' || ch == '?' || ch == '!')
                {
                    Capitalize = true;
                }
                result = result + ch;
            }
            return result;
        }
        public void Formatter()
        {
            Console.WriteLine("Enter a paragraph:");
            string input = Console.ReadLine();
            string step1 = RemoveExtraSpaces(input);
            string step2 = FixPunctuationSpacing(step1);
            string finalResult = CapitalizeSentences(step2);
            Console.WriteLine("\nCorrected Paragraph:");
            Console.WriteLine(finalResult);
            Console.WriteLine("\nProgram is perfect according to user demand");
        }
    }
}
