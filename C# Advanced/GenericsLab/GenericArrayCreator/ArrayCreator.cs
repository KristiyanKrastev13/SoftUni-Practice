using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericArrayCreator
{
   public  class ArrayCreator
    {
 

        public static T[] Create<T>(int lenght, T elements)
        {
            T[] array = new T[lenght];
            Array.Fill(array, elements);
            return array;
        }

        
    }
}
