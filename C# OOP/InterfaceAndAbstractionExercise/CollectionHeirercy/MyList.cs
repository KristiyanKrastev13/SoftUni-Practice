using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHeirercy
{
    public class MyList : IAddeble, IRemovable
    {
        private List<string> collection;
        private int used;
        public MyList()
        {
            Collection = new List<string>();

            
        }
        public List<string> Collection
        {
            get; set;
        }
        public int Used {
            get => Collection.Count;
               
            
        }
        public int Add(string item)
        {
            Collection.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
           
            string toReturn = Collection[0];
            Collection.RemoveAt(0);
            return toReturn;
        }
    }
}
