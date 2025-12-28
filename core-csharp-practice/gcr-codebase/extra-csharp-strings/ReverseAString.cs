using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extra_csharp_strings.Level_01
{
    internal class ReverseAString
    {
            public void RevString()
            {
                // Input
                Console.Write("Enter a string: ");
                string str = Console.ReadLine();
                if (str == null)
                    return;
                char[] res = new char[str.Length];
                int idx = 0;
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    res[idx] = str[i];
                    idx++;
                }
                // Output
                Console.WriteLine($"Reversed String: {new string(res)}");
            }
        }
    }
