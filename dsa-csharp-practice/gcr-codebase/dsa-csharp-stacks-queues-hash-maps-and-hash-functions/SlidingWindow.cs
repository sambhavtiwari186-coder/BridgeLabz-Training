using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Stack_Queue
{
     class SlidingWindow
    {
        public int[] SlidingWindowCal(int[] nums, int k)
        {
            if (nums.Length == 0 || k == 0)
            {
                return new int[0];
            }
            LinkedList<int> deque = new LinkedList<int>();
            List<int> res = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {

                if (deque.Count > 0 && deque.First.Value <= i - k)
                {
                    deque.RemoveFirst();
                }


                while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
                {
                    deque.RemoveLast();
                }


                deque.AddLast(i);

                if (i >= k - 1)
                {
                    res.Add(nums[deque.First.Value]);
                }

            }
            return res.ToArray();
        }

    }
}
