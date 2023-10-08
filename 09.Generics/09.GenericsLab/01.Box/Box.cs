﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> stack;

        public Box()
        {
            stack = new Stack<T>();
        }
        public int Count { get { return stack.Count; } }

        public void Add(T item)
        {
            stack.Push(item);
        }
        public T Remove()
        {
            return stack.Pop();
        }
        
    }
}
