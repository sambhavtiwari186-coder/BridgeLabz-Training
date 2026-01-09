using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Stack_Queue
{
    class LongestConsectiveSequence
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            HashSet<int> set = new HashSet<int>(nums);
            int ln = 0;

            foreach (int num in nums)
            {

                if (!set.Contains(num - 1))
                {
                    int currNum = num;
                    int cn = 1;

                    while (set.Contains(currNum + 1))
                    {
                        currNum++;
                        cn++;
                    }

                    ln = Math.Max(ln, cn);
                }
            }

            return ln;
        }
    }
}
