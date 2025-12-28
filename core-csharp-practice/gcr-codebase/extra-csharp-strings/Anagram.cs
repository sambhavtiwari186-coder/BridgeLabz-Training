using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extra_csharp_strings.Level_01
{
    internal class Anagram
        {
            public static void AnagramCheck()
            {
                // Input
                Console.Write("Enter 1st string: ");
                string s1 = Console.ReadLine();
                Console.Write("Enter 2nd string: ");
                string s2 = Console.ReadLine();
                if (s1 == null || s2 == null)
                    return;
                if (s1.Length != s2.Length)
                {
                    Console.WriteLine("Not anagrams");
                    return;
                }
                bool[] Visit = new bool[s2.Length];
                for (int i = 0; i < s1.Length; i++)
                {
                    bool fnd = false;

                    for (int j = 0; j < s2.Length; j++)
                    {
                        if (!Visit[j] && s1[i] == s2[j])
                        {
                            Visit[j] = true;
                            fnd = true;
                            break;
                        }
                    }
                    if (!fnd)
                    {
                        Console.WriteLine("Not anagrams");
                        return;
                    }
                }
                // Output
                Console.WriteLine("Anagrams");
            }
        }
    }
