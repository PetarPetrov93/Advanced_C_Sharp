using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingListStackAndQueue
{
    public class CustomStack
    {
        private const int initialCapacity = 4;
        private int[] stack;
        private int count = 0;

        public CustomStack()
        {
            stack = new int[initialCapacity];
        }

        public int Count { get; private set; }

        public void Push(int value) // done
        {
            if (Count == stack.Length)
            {
                Resize();
            }
            stack[Count] = value;
            Count++;
        }
        public int Pop() // done
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty!");
            }
            
            int value = stack[Count-1];

            Count--;
            if (Count <= stack.Length / 4)
            {
                Shrink();
            }
            return value;
        }
        public int Peek() // done
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty!");
            }
            return stack[Count-1];
        }
        public void Clear() //done
        {
            stack = new int[initialCapacity];
            Count = 0;
        }
        public void Foreach(Action<int> action) //done
        {
            for (int i = 0; i < Count; i++)
            {
                action(stack[i]);
            }
        }

        private void Resize() // done
        {
            int[] resized = new int[stack.Length * 2];
            for (int i = 0; i < Count; i++)
            {
                resized[i] = stack[i];
            }
            stack = resized;
        }

        private void Shrink() //done
        {
            int[] shrinked = new int[stack.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                shrinked[i] = stack[i];
            }
            stack = shrinked;
        }
    }
}
