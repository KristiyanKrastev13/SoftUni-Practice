using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        Stack<T> elements;
        public Box()
        {
            elements = new Stack<T>();
        }

        public int Count { get { return elements.Count; } }



        public void Add(T element)
        {
            elements.Push(element);
     
        }
        public T Remove()
        {
            return elements.Pop();
        }
  
    }
}
