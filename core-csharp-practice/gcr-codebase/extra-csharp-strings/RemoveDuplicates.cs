using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extra_csharp_strings.Level_01
{
    internal class RemoveDuplicates
        {
            public static void RemoveADuplicate()
            {
                Console.Write("Enter a string: ");
                string s = Console.ReadLine();
                if (s == null)
                    return;
                char[] Result = new char[s.Length];
                int idx = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    bool duplicate = false;
                    for (int j = 0; j < idx; j++)
                    {
                        if (s[i] == Result[j])
                        {
                            duplicate = true;
                            break;
                        }
                    }
                    if (!duplicate)
                    {
                        Result[idx] = s[i];
                        idx++;
                    }
                }
                string FinalString = new string(Result, 0, idx);
                Console.WriteLine("Duplicates removed: " + FinalString);
            }
        }
    }
