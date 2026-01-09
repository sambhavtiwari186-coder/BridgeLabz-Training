using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Stack_Queue
{
     class SortStackUsingRecursion
    {
        public void SortStackRec(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                int temp = stack.Pop();
                SortStackRec(stack);
                Insert(stack, temp);
            }
        }

        void Insert(Stack<int> st, int val)
        {
            if (st.Count == 0 || st.Peek() <= val)
            {
                st.Push(val);
                return;
            }

            int temp = st.Pop();
            Insert(st, val);
            st.Push(temp);
        }

    }
}
