using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BridgeLabzTraining.Methods.level2
{
    internal class RandomAverageOfNumber
    {
       public static void RandomAvg()
        {
            int[] RandomNumberArray = RandomArrayGeneration(5);
            Console.WriteLine("Generated 4-digit random numbers:");
            for (int i = 0; i < RandomNumberArray.Length; i++)
            {
                Console.WriteLine(RandomNumberArray[i]);
            }
           double[] resultArr = FindAverageMinMax(RandomNumberArray);
            //Display the results
            Console.WriteLine("Average value = " + resultArr[0]);
            Console.WriteLine("Minimum value = " + resultArr[1]);
            Console.WriteLine("Maximum value = " + resultArr[2]);
        }
        //Method to generate 4-digit random numbers array
        public static int[] RandomArrayGeneration(int s)
        {
            int[] num = new int[s];
            Random rand = new Random();
            for (int i = 0; i < s; i++)
            {
                num[i] = rand.Next(1000, 10000);
            }
            return num;
        }
        //Method to find average, min and max
        public static double[] FindAverageMinMax(int[] nums)
        {
            int min = nums[0];
            int max = nums[0];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                min = Math.Min(min, nums[i]);
                max = Math.Max(max, nums[i]);
            }
            double avg = (double)sum / nums.Length;
            return new double[] { avg, min, max };
        }

    }
}