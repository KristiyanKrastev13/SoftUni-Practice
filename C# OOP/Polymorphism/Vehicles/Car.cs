using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double litersPerKm, double tankCapacity) : base(fuelQuantity, litersPerKm, tankCapacity)
        {
        }

        public override void Drive(double km)
        {
   
            double enoughtFuel = km * (this.LitersPerKm + 0.9);
            if (enoughtFuel < this.FuelQuantity)
            {
                Console.WriteLine($"Car travelled {km} km");
                FuelQuantity -= enoughtFuel;
            }
            else
            {
                Console.WriteLine("Car needs refueling");
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
                FuelQuantity += litters;
            }
        }

    }
}
