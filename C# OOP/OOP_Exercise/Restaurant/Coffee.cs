using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const decimal DefautCoffePrice = 3.50M;
        private const double MillilitersCofe = 50;
        public Coffee(string name) : base(name, DefautCoffePrice, MillilitersCofe)
        {
        }
        
    }
}
