using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.Level_03
{
    internal class FootballTeam
    {
        static void Players()
        {
            //  Create an int array of size 11
            int[] Height = new int[11];
            // Generate random heights between 150 and 250
            Random rand = new Random();
            for (int i = 0; i < Height.Length; i++)
            {
                Height[i] = rand.Next(150, 251);
            }
            // Display heights
            Console.WriteLine("Heights of Players (in cm):");
            for (int i = 0; i < Height.Length; i++)
            {
                Console.Write(Height[i] + " ");
            }
            Console.WriteLine();
            // Calling methods
            int sum = FindSum(Height);
            double mean = FindMean(Height);
            int shortest = FindShortest(Height);
            int tallest = FindTallest(Height);
            //  Display results
            Console.WriteLine("\nResults:");
            Console.WriteLine("Shortest Height: " + shortest + " cm");
            Console.WriteLine("Tallest Height: " + tallest + " cm");
            Console.WriteLine("Mean Height: " + mean + " cm");
        }
        //  Method to find sum of all elements
        static int FindSum(int[] heights)
        {
            int sum = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                sum += heights[i];
            }
            return sum;
        }
        //  to find mean height
        static double FindMean(int[] heights)
        {
            int sum = FindSum(heights);
            return (double)sum / heights.Length;
        }
        //  Method to find shortest height
        static int FindShortest(int[] heights)
        {
            int minimum = heights[0];
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] < minimum)
                {
                    minimum = heights[i];
                }
            }
            return minimum;
        }
        //  Method to find tallest height
        static int FindTallest(int[] heights)
        {
            int maximum = heights[0];
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > maximum)
                {
                    maximum = heights[i];
                }
            }
            return maximum;
        }
    }
}
