using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> list;
        private int index = 0;

        public ListyIterator()
        {
            list = new List<T>();
        }

        public void Create(List<T> array)
        {
            list.AddRange(array);
        }

        public bool Move() 
        {
            if (index + 1 < list.Count)
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasNext()
        {
            if (index + 1 < list.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(list[index]);
            }
        }


    }
}
