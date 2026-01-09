using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Stack_Queue
{
    class SubarrayWithZeroSum
    {
        public void FindZeroSumSubarrays(int[] arr)
        {
            Dictionary<int, List<int>> mp = new Dictionary<int, List<int>>();
            int sum = 0;

            mp[0] = new List<int> { -1 };

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (mp.ContainsKey(sum))
                {
                    foreach (int startIndex in mp[sum])
                    {
                        Console.WriteLine($"Subarray found from {startIndex + 1} to {i}");
                    }
                    mp[sum].Add(i);
                }
                else
                {
                    mp[sum] = new List<int> { i };
                }
            }
        }
    }
}
