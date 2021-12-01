using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAgain
{
    public class CustomList<T> : List<T>
    {
        private List<T> list;
        public CustomList()
        {
           list = new List<T>();
        }
    }
}
