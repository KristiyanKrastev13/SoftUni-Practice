using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public Car()
        {
            TravelledDistance = 0;
        }
        public Car(string model, double fuel, double consumption) :this()
        {
            Model = model;
            FuelAmount = fuel;
            FuelConsumptionPerKilometer = consumption;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public  double TravelledDistance { get; set; }

        public void CanDrive(double distance)
        {
            double neededFuel = distance * FuelConsumptionPerKilometer;
            if (FuelAmount >= neededFuel)
            {
               TravelledDistance += distance;
                FuelAmount -= neededFuel;             
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive"); 
            }
            
        }

        public override string ToString()
        {
            return ($"{this.Model} {this.FuelAmount:f2} {this.TravelledDistance}");
        }

    }
}
