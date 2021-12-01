using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Food : Product
    {
        public Food(string name, decimal price, double grams)
        {
            Name = name;
            Price = price;
            Grams = grams;
        }
        public double Grams { get; set; }
    }
}
