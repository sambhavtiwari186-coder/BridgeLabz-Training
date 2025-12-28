using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.Level_01
{
    internal class Substring
    {
        public void FindSubstring (){

            // Taking String as Input from user
            Console.WriteLine("Enter the String Here");
            string s = Console.ReadLine();
            string s1= s.Substring(1,4);
            string s2 = FindStringMeth(s, 1, 4);
            Console.WriteLine("Substring from the built-in-method " + s1);
            Console.WriteLine("Substring from different method " + s2);
        }
        public string FindStringMeth(string a,int i,int j) {
            string s = "";
            while (i <= j)
            {
                s += a[i];
                i++;
            }
            return s;
        }
    }
}
