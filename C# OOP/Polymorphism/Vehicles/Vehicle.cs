using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
   public abstract class Vehicle
    {
        private double fuelQuantity;
        private double tankCapacity;
        public Vehicle(double fuelQuantity, double litersPerKm, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            LitersPerKm = litersPerKm;
            

        }
        public double FuelQuantity {
            get => fuelQuantity;
            set
            {
                if (value > TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }

            }
             }

        public double LitersPerKm { get; set; }

        public double TankCapacity { get; set; }

        public virtual void Drive(double km)
        {

        }

        public virtual void Drive(double km, double multyplayer)
        {

        }

        public virtual void Refuel(double litters)
        {
            if (litters < 1)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
        }
    }
}
