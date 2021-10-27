using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
   public class Vehicle
    {
        public Vehicle(int horsepower, double fuel)
        {
            HorsePower = horsepower;
            Fuel = fuel;
            DefaultFuelConsumption = 1.25;
            FuelConsumption = DefaultFuelConsumption;
        }
        public double DefaultFuelConsumption { get; set; }

       public virtual double FuelConsumption { get; set; }

        public double Fuel { get; set; }
        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            double consumedFuel = this.FuelConsumption * kilometers;
            this.Fuel -= consumedFuel;
        }

    }
}
