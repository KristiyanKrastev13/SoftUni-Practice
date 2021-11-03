using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizza
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            toppings = new List<Topping>();
        }

        public string Name {
            get => this.name;
            private set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }
        public Dough Dough { get; private set; }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count < 10)
            {
                toppings.Add(topping);
            }
            else
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }

        public double GetCalories()
        {
            double totalCalories = 0;
            foreach (var topping in toppings)
            {
                totalCalories += topping.GetCalories();
            }
            totalCalories += Dough.GetCalories();
            return totalCalories;
            
        }

        
    }
}
