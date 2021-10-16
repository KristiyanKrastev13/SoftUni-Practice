using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkiRental
{
    public class SkiRental
    {
        public SkiRental(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Data = new List<Ski>();
            Count = 0;
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Ski> Data { get; set; }
         public int Count { get; set; }

        public void Add(Ski ski)
        {
            if(this.Data.Count +1 <= Capacity)
            {
                Data.Add(ski);
                Count++;
            }
        }

        public bool Remove(string manufactor, string model)
        {
            
            if (Data.Any(x => x.Manufacturer == manufactor) && Data.Any(x => x.Model == model))
            {
                Ski current = (Ski)Data.Where(x => x.Manufacturer == manufactor).First(x => x.Model == model);
                Data.Remove(current);
                Count--;
                return true;
                
            }
            else
            {
                return false;
            }
        }

        public Ski GetNewestSki()
        {
            if (Data.Count > 0)
            {
                Ski newest = (Ski)Data.OrderByDescending(x => x.Year).First();
                return newest;
            }
            else
            {
                return null;
            }
           
        }

        public Ski GetSki(string manufacturer, string model)
        {

            Ski current = (Ski)Data.Where(x => x.Manufacturer == manufacturer).First(x => x.Model == model);
            if (current != null)
            {
                return current;
            }
            else
            {
                return null;
            }

        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Data)
            {
                sb.Append(item.ToString());
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
