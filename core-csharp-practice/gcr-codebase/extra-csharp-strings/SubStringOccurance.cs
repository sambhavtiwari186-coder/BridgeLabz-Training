using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extra_csharp_strings.Level_01
{
    internal class SubStringOccurance
    {
            public static void Occurance()
            {
                // Input
                Console.Write("Enter a string: ");
                string str = Console.ReadLine();
                if (str == null)
                    return;
                Console.Write("Enter substring: ");
                string subStr = Console.ReadLine();
                if (subStr == null || subStr.Length == 0)
                    return;
                int cnt = 0;
                for (int i = 0; i <= str.Length - subStr.Length; i++)
                {
                    bool match = true;
                    for (int j = 0; j < subStr.Length; j++)
                    {
                        if (str[i + j] != subStr[j])
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match)
                        cnt++;
                }
                //Output
                Console.WriteLine("Occurrences: " + cnt);
            }
        }
    }

