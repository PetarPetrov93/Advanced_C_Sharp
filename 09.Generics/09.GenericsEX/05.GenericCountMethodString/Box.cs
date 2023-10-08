using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GenericCountMethodStrings
{
    public class Box<T> where T : IComparable
    {
        private List<T> items;
       
        public Box()
        {           
            Items = new List<T>();
        }
        
        public List<T> Items 
        {
            get { return items; }
            set { items = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in Items)
            {
                sb.AppendLine(typeof(T) + ": " + item);
            }
            
            return sb.ToString().TrimEnd();
        }
        public void SwapElements(int index1, int index2)
        {
            
            T element = Items[index1];
            Items[index1] = Items[index2];
            Items[index2] = element;
            
        }
        public int Counter (T element)
        {
            int counter = 0;

            foreach (var item in Items)
            {
                if (item.CompareTo(element) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
