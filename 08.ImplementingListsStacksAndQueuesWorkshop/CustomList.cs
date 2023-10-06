using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingListStackAndQueue
{
    public class CustomList
    {
        private const int initialListSize = 2;
        private int[] list;
        private int count;

        public CustomList()
        {
            list = new int[initialListSize];
        }
        public int Count { get; private set; }

        public int this[int indexer] // this is an indexer -> acts like a property but it works with the indexes of the collection [index]; when you ask for an element at a given index it returns the value in the cell
        {
            
            get 
            { 
                CheckIfIndexIsInRange(indexer);
                return list[indexer]; 
            }

            set 
            { 
                CheckIfIndexIsInRange(indexer);
                list[indexer] = value; 
            }
        }

        public void Add(int number) //done
        {
            if (Count == list.Length)
            {
                Resize();
            }

            list[Count] = number;
            Count++;
        }
        public void Insert(int index, int item) // done
        {
            CheckIfIndexIsInRange(index);
            ShiftRight(index);
            list[index] = item;
        }
        public void Remove() //done
        {
            if (Count <= list.Length/4)
            {
                Shrink();
            }
            list[Count] = default;
            Count--;
        }
        public void RemoveAt(int index) // done
        {
            CheckIfIndexIsInRange(index);
            ShiftLeft(index);

        }
        public bool Contains(int number) // done
        {
            foreach (int item in list)
            {
                if (item == number)
                {
                    return true;
                }
            }
            return false;
        }
        public void Swap (int index1, int index2) // done
        {
            CheckIfIndexIsInRange(index1);
            CheckIfIndexIsInRange(index2);

            int num1 = list[index1];
            list[index1] = list[index2];
            list[index2] = num1;
        }
        public void Clear() //done
        {
            list = new int[initialListSize];
            Count = 0;
        }
        private void Resize() //done
        {
            int[] resized = new int[initialListSize*2];
            for (int i = 0; i < Count; i++)
            {
                resized[i] = list[i];
            }
            list = resized;
        }
        private void Shrink() //done
        {
            int[] shrinked = new int[list.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                shrinked[i] = list[i];
            }
            list = shrinked;
        }
        private void ShiftLeft(int index) // when removing an element at a given index // done
        {
            if (Count <= list.Length / 4)
            {
                Shrink();
            }
            for (int i = index; i < Count-1; i++)
            {
                list[i] = list[i+1];
            }
            Count--;
        }
        private void ShiftRight(int index) // when inserting an element in the list // done
        {
            if (Count == list.Length)
            {
                Resize();
            }
            for (int i = Count-1; i >= index; i--)
            {
                list[i + 1] = list[i];
            }
            Count++;
        }
        private void CheckIfIndexIsInRange(int index) //done
        {
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException("Ivalid index. Index was outside of the bounderies of the list");
            }
        }


    }
}
