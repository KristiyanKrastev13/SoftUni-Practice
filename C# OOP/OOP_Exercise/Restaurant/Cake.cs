using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double DefautCalories = 1000;
        private const double DefautGrams = 250;
        private const decimal DefautPrice = 5;

        public Cake(string name) : base(name, DefautPrice, DefautGrams, DefautCalories)
        {


        }
    }
}
