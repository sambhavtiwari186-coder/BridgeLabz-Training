using System;

namespace BridgeLabzTraining.String.Level_01
{
    internal class StringEquals
    {
        public void StringEq()
        {
            // Taking Two Strings as Input from User
            Console.WriteLine("Enter the First String Here");
            string a = Console.ReadLine();

            Console.WriteLine("Enter the Second String Here");
            string b = Console.ReadLine();

            bool IsEquals = FindEquals(a, b);
            bool IsEqualsFun = string.Equals(a, b);

            Console.WriteLine("Result of comparison by built-in method: " + IsEqualsFun);
            Console.WriteLine("Result of comparison by manual method: " + IsEquals);
        }
        public bool FindEquals(string a, string b)
        {
            // checking if the number is null or not
            if (a == null || b == null)
            {
                return false;
            }
            // checking the length of the array
            if (a.Length != b.Length)
            {
                return false;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
