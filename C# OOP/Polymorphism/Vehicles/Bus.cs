using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double litersPerKm, double tankCapacity) : base(fuelQuantity, litersPerKm, tankCapacity)
        {
        }

        public override void Drive(double km)
        {
            double enoughtFuel = km * this.LitersPerKm;
            if (enoughtFuel < this.FuelQuantity)
            {
                Console.WriteLine($"Bus travelled {km} km");
                FuelQuantity -= enoughtFuel;
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }
        public override void Drive(double km, double multyplayer)
        {
            double enoughtFuel = km * (this.LitersPerKm + 1.4);
            if (enoughtFuel < this.FuelQuantity)
            {
                Console.WriteLine($"Bus travelled {km} km");
                FuelQuantity -= enoughtFuel;
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
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
