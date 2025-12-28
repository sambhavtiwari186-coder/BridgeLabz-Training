using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extra_csharp_strings.Level_01
{
    internal class LongestWord
        {
            public static void LongWord()
            {
                // Input
                Console.Write("Enter a sentence: ");
                string str = Console.ReadLine();
                if (str == null)
                    return;
                int maxLength = 0;
                int currLength = 0;
                int endIdx = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != ' ')
                        currLength++;
                    else
                    {
                        if (currLength > maxLength)
                        {
                            maxLength = currLength;
                            endIdx = i - 1;
                        }
                        currLength = 0;
                    }
                }
                if (currLength > maxLength)
                {
                    maxLength = currLength;
                    endIdx = str.Length - 1;
                }
                // Output
                string longest = str.Substring(endIdx - maxLength + 1, maxLength);
                Console.WriteLine($"Longest word: {longest}");
            }
        }
    }
