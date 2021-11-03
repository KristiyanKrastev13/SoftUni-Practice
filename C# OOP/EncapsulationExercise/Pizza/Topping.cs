using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    public class Topping
    {
        private const int minTopping = 1;
        private const int maxTopping = 50;
        private string toppingType;
        private int grams;
        public Topping(string type, int grams)
        {
            ToppingType = type;
            Grams = grams;
        }

        public string ToppingType {
            get => this.toppingType;
          private  set
            {
                string toLower = value.ToLower();
                if (toLower != "meat" && toLower != "veggies" && toLower != "cheese" && toLower != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.toppingType = value;
            }
        }
        public int Grams {
            get => this.grams;
           private set
            {
                if (value < minTopping || value > maxTopping)
                {
                    throw new ArgumentException($"{this.toppingType} weight should be in the range [{minTopping}..{maxTopping}].");
                }
                this.grams = value;
            }
        }

        public double GetCalories()
        {
            string toLower = this.toppingType.ToLower();
            double typeModifier = 0;
            if (toLower == "meat")
                typeModifier = 1.2;
            else if (toLower == "veggies")
                typeModifier = 0.8;
            else if (toLower == "cheese")
                typeModifier = 1.1;
            else if(toLower == "sauce")
                typeModifier = 0.9;

            double result = (grams * 2) * typeModifier;
            return result;
            
        }
    }
}
