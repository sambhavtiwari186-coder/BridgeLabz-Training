using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extra_csharp_strings.Level_01
{
    internal class ToggleCase
    {
            public static void Caller()
            {
                //Input
                Console.Write("Enter a string: ");
                string String = Console.ReadLine();
            if (String == null)
                return;
                char[] Result = new char[String.Length];
                for (int i = 0; i < String.Length; i++)
                {
                    char ch = String[i];
                    if (ch >= 'a' && ch <= 'z')
                        Result[i] = (char)(ch - 32);
                    else if (ch >= 'A' && ch <= 'Z')
                        Result[i] = (char)(ch + 32);
                    else
                        Result[i] = ch;
                }
                //Output
                string toggleStr = new string(Result);
                Console.WriteLine($"Toggled case string: {toggleStr}");
            }
        }
    }
