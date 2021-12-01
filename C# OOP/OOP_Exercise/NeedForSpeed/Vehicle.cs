using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double defaultConsumation = 1.25;
        public Vehicle(int hp, double fuel)
        {
            HorsePower = hp;
            Fuel = fuel;
            DefaultFuelConsumption = defaultConsumation;
        }
        public double DefaultFuelConsumption { get; set; }
        public virtual double FuelConsumption { get; set; }
        public double Fuel { get; set; }

        public int HorsePower { get; set; }
        public int MyProperty { get; set; }

       public virtual void Drive(double kilometers)
        {
            double burnedFuel = kilometers * DefaultFuelConsumption;
            this.Fuel -= burnedFuel;
        }
    }
}
