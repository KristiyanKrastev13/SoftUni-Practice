using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwap
{
   public class Box<T>
    {
        public Box(T value)
        {
            Value = value;
        }
        public T Value { get; set; }



    }
}
