using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
   public class Product
    {
        private string name;
        private double cost;
        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
        public string Name {
            get => this.name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
                }
        public double Cost {
            get => this.cost;
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cost cannot be negative");
                }
                this.cost = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }

    }
}
