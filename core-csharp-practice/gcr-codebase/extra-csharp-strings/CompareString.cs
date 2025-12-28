using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extra_csharp_strings.Level_01
{
    internal class CompareString
    {
            public static void StringCompare()
            {
                //Input
                Console.Write("Enter 1st string: ");
                string s1 = Console.ReadLine();
                Console.Write("Enter 2nd string: ");
                string s2 = Console.ReadLine();
                if (s1 == null || s2 == null)
                    return;
                int minLength = s1.Length < s2.Length ? s1.Length : s2.Length;
                bool isDiff = false;
                for (int i = 0; i < minLength; i++)
                {
                    if (s1[i] < s2[i])
                    {
                        Console.WriteLine($"\"{s1}\" comes before \"{s2}\" in lexicographical order");
                        isDiff = true;
                        break;
                    }
                    else if (s1[i] > s2[i])
                    {
                        Console.WriteLine($"\"{s2}\" comes before \"{s1}\" in lexicographical order");
                        isDiff = true;
                        break;
                    }
                }
                //Output
                if (!isDiff)
                {
                    if (s1.Length < s2.Length)
                        Console.WriteLine($"\"{s1}\" comes before \"{s2}\" in lexicographical order");

                    else if (s1.Length > s2.Length)
                        Console.WriteLine($"\"{s2}\" comes before \"{s1}\" in lexicographical order");

                    else
                        Console.WriteLine("Both strings are equal");
                }
            }
        }
    }
