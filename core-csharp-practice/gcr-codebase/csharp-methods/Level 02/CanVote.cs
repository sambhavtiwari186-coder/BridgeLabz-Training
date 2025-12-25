using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level2
{
    internal class CanVote
    {
        public static void CanVoteOrNot()
        {
            int[] Age = new int[10];
            //Getting input from the user
            Console.WriteLine("Enter age of 10 students:");
            for (int i = 0; i < 10; i++)
            {
                Age[i] = Convert.ToInt32(Console.ReadLine());
                bool CanVote = CanStudentVote(Age[i]);
                if (CanVote)
                {
                    Console.WriteLine("Can vote");
                }
                else
                {
                    Console.WriteLine("Cannot vote");
                }
            }
        }
        //Method for checking can vote or not
        public static bool CanStudentVote(int age)
        {
            if (age < 0)
            {
                return false;
            }
            if (age >= 18)
            {
                return true;
            }
            return false;
        }
    }
}