using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.Level_01
{
    internal class StringCharacters
    {
        public void Characters() {
            // Taking String As Input From User
            Console.WriteLine("Enter The String Here");
        string a = Console.ReadLine();
         char[]  ch =  a.ToCharArray();
            Console.WriteLine("Printing Every Character of the String using ToCharArray");
            for (int i = 0; i < a.Length; i++) { 
             Console.Write(ch[i]+ " ");
            }
            Console.WriteLine();
            // Printing the charcters without built in method
            Console.WriteLine("Printing Every Character of the String using Normal Method");
            CharacterFind(a);
        }
        public void CharacterFind(string a) { 
        for(int i=0; i < a.Length; i++)
            {
                Console.Write(a[i]+ " ");
            }
        }
    }
}
