using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Stack_Queue
{
     class StockSpan
    {
        public int[] StFun(int[] prices)
        {
            int n = prices.Length;
            int[] spanning = new int[n];
            Stack<int> st = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                while (st.Count > 0 && prices[st.Peek()] <= prices[i])
                {
                    st.Pop();
                }


                spanning[i] = (st.Count == 0) ? i + 1 : i - st.Peek();
                st.Push(i);
            }

            return spanning;
        }

    }
}
