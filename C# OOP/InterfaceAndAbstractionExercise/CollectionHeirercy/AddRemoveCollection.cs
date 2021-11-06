using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHeirercy
{
    class AddRemoveCollection : IAddeble, IRemovable
    {
        private List<string> collection;
        private int count;
        public AddRemoveCollection()
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
            Collection.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            int index = Collection.Count - 1;
            string toReturn = Collection[index];
            Collection.RemoveAt(index);
            return toReturn;
        }
    }
}
