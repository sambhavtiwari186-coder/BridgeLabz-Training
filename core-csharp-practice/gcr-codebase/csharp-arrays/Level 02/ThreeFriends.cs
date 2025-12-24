using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Array.Level__2
{
    internal class ThreeFriends
    {
        public void ThreeFriendsCal() {
                string[] name = { "Amar", "Akbar", "Anthony" };
                int[] age = new int[3];
                int[] height = new int[3];
          // Taking input from the User
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Enter age of " + name[i] + ":");
                    age[i] = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter height of " + name[i] + ":");
                    height[i] = Convert.ToInt32(Console.ReadLine());
                }
         // Finding youngest friend
                int youngest = 0;
                for (int i = 1; i < 3; i++)
                {
                    if (age[i] < age[youngest])
                    {
                        youngest = i;
                    }
                }
          // Finding tallest friend
                int tallest = 0;
                for (int i = 1; i < 3; i++)
                {
                    if (height[i] > height[tallest])
                    {
                        tallest = i;
                    }
                }
         // Displaying results
                Console.WriteLine("\nYoungest Friend: " + name[youngest]);
                Console.WriteLine("Tallest Friend: " + name[tallest]);
            }
        }

    }
