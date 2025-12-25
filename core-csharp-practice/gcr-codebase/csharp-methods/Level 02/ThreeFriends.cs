using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.level2
{
    internal class YoungestAndTallest
    {
        public static void YoungestAndTallestFind()
        {
            string[] Friends = { "Amar", "Akbar", "Anthony" };

            int[] AgeArr = new int[3];
            double[] HeightArray = new double[3];
            //getting input from user
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter age of {Friends[i]}: ");
                AgeArr[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Enter height of {Friends[i]}: ");
                HeightArray[i] = Convert.ToDouble(Console.ReadLine());
            }
            //Calling the Methods
            int YoungestFriend = FindYoungest(AgeArr);
            int TallestFriend = FindTallest(HeightArray);
            Console.WriteLine("Youngest friend is " + Friends[YoungestFriend]);
            Console.WriteLine("Tallest friend is " + Friends[TallestFriend]);
        }
        //Method for finding the tallest friend
        public static int FindTallest(double[] heightsArr)
        {
            int tallestFriend = 0;

            for (int i = 1; i < heightsArr.Length; i++)
            {
                if (heightsArr[i] > heightsArr[tallestFriend])
                {
                    tallestFriend = i;
                }
            }
            return tallestFriend;
        }
        // Method to find the youngest friend
        public static int FindYoungest(int[] agesArr)
        {
            int youngestFriend = 0;

            for (int i = 1; i < agesArr.Length; i++)
            {
                if (agesArr[i] < agesArr[youngestFriend])
                {
                    youngestFriend = i;
                }
            }
            return youngestFriend;
        }
    }
}