using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extra_csharp_strings.Level_01
{
    internal class RemoveCharacter
    {
        public static void Rev()
        {
            // Input
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();
            if (s == null)
                return;
            Console.Write("Enter character: ");
            string charInput = Console.ReadLine();
            if (charInput == null || charInput.Length == 0)
                return;
            char removeCharacter = charInput[0];
            char[] res = new char[s.Length];
            int idx = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != removeCharacter)
                {
                    res[idx] = s[i];
                    idx++;
                }
            }
            // Output
            string finalString = new string(res, 0, idx);
            Console.WriteLine("Modified String: " + finalString);
        }
    }
}
