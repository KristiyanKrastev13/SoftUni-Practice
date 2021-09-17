using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public Car()
        {
            Weight = 0;
            Color = "n/a";
        }
        public Car(string model, Engine engine) : this()
        {
            Model = model;
            Engine = engine;
        }
        public Car(string model, Engine engine, string color) : this()
        {
            Model = model;
            Engine = engine;
            Color = color;
        }
        public Car(string model, Engine engine, int weight) : this()
        {
            Model = model;
            Engine = engine;
            Weight = weight;
        }
        public Car(string model, Engine engine, int weight, string color) : this()
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }


        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Model +":" + Environment.NewLine);
            sb.Append("  " + (this.Engine.Model) + ":" + Environment.NewLine);
            sb.Append("    " + "Power: " + (this.Engine.Power) + Environment.NewLine);
            sb.Append("    " + "Displacement: " +(this.Engine.Displacement) + Environment.NewLine);
            sb.Append("    " + "Efficiency: " + (this.Engine.Efficiency) + Environment.NewLine);
            if (Weight != 0)
            {
                sb.Append("  " + "Weight: " + (this.Weight) + Environment.NewLine);
            }
            else
            {
                sb.Append("  " + "Weight: " + "n/a" + Environment.NewLine);
            }
            
            sb.Append("  " + "Color: " + (this.Color) + Environment.NewLine);



            return sb.ToString();
                //$"{this.Model}:\n   {this.Engine.Model}:\n        Power: {Engine.Power}\n       Displacement: {this.Engine.Displacement}\n      Efficiency:{this.Engine.Efficiency}\n   Weight: {this.Weight}\n     Color: {this.Color}";
        }
    }
}
