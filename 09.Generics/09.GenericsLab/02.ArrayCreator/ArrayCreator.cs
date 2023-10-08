using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        
        public static T[] Create<T>(int length, T item)
        {
            T[] createdArray = new T[length];

            for (int i = 0; i < length; i++)
            {
                createdArray[i] = item;
            }

            return createdArray;
        }
    }
}
