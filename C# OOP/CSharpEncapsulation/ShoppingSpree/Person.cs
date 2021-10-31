using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
   public class Person
    {
        private string name;
        private double money;
        private List<Product> products;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            products = new List<Product>();
        }

        public string Name {
            get => this.name;
           private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public double Money {
            get => this.money;
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public List<Product> Products
        {
            get => this.products;
         }

        public void BuyProduct(Product product)
        {
            if (product.Cost > money)
            {
                throw new InvalidOperationException($"{Name} can't afford {product.Name}");
            }
            else
            {
                Money -= product.Cost;

                Console.WriteLine($"{Name} bought {product.Name}");

                products.Add(product);
            }
        }
        public override string ToString()
        {
            if (products.Count == 0)
            {
                return "Nothing bought";
            }
            else
            {
                return $"{string.Join(", ", this.products)}";
            }
        }
    }
}
