using System;
using System.Collections.Generic;
using System.Text;

namespace CarAndCargo
{
    public class Tire
    {
        public Tire(double presure, double age)
        {
            TirePresure = presure;

            TireAge = age;
        }

        public double TirePresure { get; set; }

        public double TireAge { get; set; }
    }
}
