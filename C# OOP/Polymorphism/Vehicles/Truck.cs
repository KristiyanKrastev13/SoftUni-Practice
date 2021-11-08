using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double litersPerKm, double tankCapacity) : base(fuelQuantity, litersPerKm, tankCapacity)
        {
        }

        public override void Drive(double km)
        {
            double enoughtFuel = km * (this.LitersPerKm + 1.6);
            if (enoughtFuel < this.FuelQuantity)
            {
                Console.WriteLine($"Truck travelled {km} km");
                FuelQuantity -= enoughtFuel;
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double litters)
        {
            base.Refuel(litters);
            if (litters + FuelQuantity > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {litters} fuel in the tank");
            }
            else
            {
                double littersToRefuel = litters * 0.95;
                FuelQuantity += littersToRefuel;
            }
            
        }
    }
}
