using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingListStackAndQueue
{
    public class CustomQueue
    {
        private const int initialCapacity = 4;
        private int[] queue;
        private int count = 0;

        public CustomQueue()
        {
            queue = new int[initialCapacity];
        }

        public int Count { get; private set; }

        public void Enqueue(int value) // done
        {
            if (Count == queue.Length)
            {
                Resize();
            }
            queue[Count] = value;
            Count++;
        }
        public int Dequeue() //done
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("CustomQueue is empty!");
            }
            int value = queue[0];

            ShiftLeft();
            if (Count <= queue.Length / 4)
            {
                Shrink();
            }
            return value;
        }

        public int Peek() // done
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("CustomQueue is empty!");
            }
            return queue[0];
        }
        public void Clear() //done
        {
            queue = new int[initialCapacity];
            Count = 0;
        }
        public void Foreach(Action<int> action) //done
        {
            for (int i = 0; i < Count; i++)
            {
                action(queue[i]);
            }
        }

        private void Resize() // done
        {
            int[] resized = new int[queue.Length * 2];
            for (int i = 0; i < Count; i++)
            {
                resized[i] = queue[i];
            }
            queue = resized;
        }

        private void Shrink() //done
        {
            int[] shrinked = new int[queue.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                shrinked[i] = queue[i];
            }
            queue = shrinked;
        }

        private void ShiftLeft() // done
        {
            Count--;
            for (int i = 0; i < Count; i++)
            {
                queue[i] = queue[i + 1];
            }     
        }
    }
}
