using System;
using System.Collections.Generic;
using System.Text;

namespace CarAndCargo
{
    public class Cargo
    {

        public Cargo(double weight, string type)
        {
            CargoWeight = weight;
            CargoType = type;
        }
        public string CargoType { get; set; }

        public double CargoWeight { get; set; }
    }
}
