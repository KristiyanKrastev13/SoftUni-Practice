using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    public class Dough
    {
        private const int minGrams = 1;
        private const int maxGrams = 200;
        private string type;
        private string technique;
        private int grams;
        public Dough(string type, string technique, int grams)
        {
            Type = type;
            Technique = technique;
            Grams = grams;

        }

        public string Type {
            get => this.type;
           private set 
            {
                string toLower = value.ToLower();
                if (toLower != "white" && toLower != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.type = value;
            } 
        }
        public string  Technique {
            get => this.technique;
         private   set
            {
                string toLower = value.ToLower();
                if (toLower != "crispy" && toLower != "chewy" && toLower != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.technique = value;
            }
        }
        public int Grams {
            get => this.grams;
          private  set
            {
                if (value < minGrams || value > maxGrams)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{minGrams}..{minGrams}].");
                }
                this.grams = value;
            }
        }

        public double GetCalories()
        {
            double typeModifier = 0;
            double techniqueModifier = 0;
            string toLower = this.type.ToLower();
            string techniqeToLower = this.technique.ToLower();
            if (toLower == "white")          
                typeModifier = 1.5;           
            else
                typeModifier = 1.0;

            if (techniqeToLower == "crispy")
                techniqueModifier = 0.9;
            else if (techniqeToLower == "chewy")
                techniqueModifier = 1.1;
            else
                techniqueModifier = 1.0;
            double result = (this.grams * 2) * typeModifier * techniqueModifier;
            return result;
        }
    }
}
