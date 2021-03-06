using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxString
{
    public class Box<T>
    {
        public Box(T value)
        {
            Value = value;
        }
        public T Value { get; set; }


        public override string ToString()
        {
            string result = $"{Value.GetType()}: {Value}";
            return result;
        }

    }
}
