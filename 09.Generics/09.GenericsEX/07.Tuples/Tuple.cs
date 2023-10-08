﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Tuples
{
    public class Tuple<T1, T2>
    {
        private T1 item1;
        private T2 item2;

        public Tuple(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public T1 Item1 
        {
            get { return item1; }
            set { item1 = value; }
        }
        public T2 Item2 
        {   get { return item2; } 
            set { item2 = value; }
        }
    }
}
