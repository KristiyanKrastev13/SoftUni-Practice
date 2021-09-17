using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        
        public Engine()
        {
            Displacement = "n/a";
            Efficiency = "n/a";
        }
        public Engine(string model, int power) :this()
        {
            Model = model;
            Power = power;
        }

        public Engine(string model, int power, string displacement) :this()
        {
            Model = model;
            Power = power;
            Displacement = displacement;
        }

        public  Engine(string model, int power, string displacement, string effic):this()
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = effic;
        }


        public string Model { get; set; }

        public int Power { get; set; }

        public string Displacement { get; set; }

        public string Efficiency { get; set; }
    }
}
