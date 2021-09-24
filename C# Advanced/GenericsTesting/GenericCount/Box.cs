using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCount
{
    public class Box<T>
    {
        public T Value { get; set; }
        
        public Box(T value)
        {
            Value = value;
        }
    }
}
