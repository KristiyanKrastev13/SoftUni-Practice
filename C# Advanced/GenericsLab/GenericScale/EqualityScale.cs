using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    class EqualityScale<T>
    {
        public T First { get; set; }

        public T Second { get; set; }

        public EqualityScale(T first, T second)
        {
            First = first;
            Second = second;
        }

        public  bool AreEqual()
        {


            return First.Equals(Second);
        }

    }
}
