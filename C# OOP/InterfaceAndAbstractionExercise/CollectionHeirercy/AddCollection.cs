using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHeirercy
{
    public class AddCollection : IAddeble
    {
        private List<string> collection;
        private int count;
        public AddCollection()
        {
            Collection = new List<string>();
            Count = 0;
        }
        public List<string> Collection
        {
            get; set;
        }
        public int Count { get; private set; }

        public int Add(string item)
        {
            Collection.Add(item);
            Count++;
            return Count - 1;
            
        }
    }
}
