using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Stack_Queue
{
     class TwoSum
    {
        //method to calcute the two sum
        public int[] CalTwoSum(int[] nums, int target)
        {
            //creating the dictnary
            Dictionary<int, int> mp = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int difference = target - nums[i];

                // checking if the dict contains
                if (mp.ContainsKey(difference))
                {
                    return new int[] { mp[difference], i };
                }

                if (!mp.ContainsKey(nums[i]))
                {
                    mp.Add(nums[i], i);
                }

            }

            // if there is no solution return negative
            return new int[] { -1, -1 };
        }
    }
}
