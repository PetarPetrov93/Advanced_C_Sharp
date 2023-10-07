using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        private T input;
        public Box(T input) 
        {
            this.input = input;
            
        }

        public override string ToString()
        {
            
            return input.GetType().FullName +": " + input;
        } 

    }
}
