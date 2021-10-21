﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StreetRacing
{
   public class Car
    {
        public Car(string make, string model, string licensePlate, int horsepower, double weight)
        {
            Make = make;
            Model = model;
            LicensePlate = licensePlate;
            HorsePower = horsepower;
            Weight = weight;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public int HorsePower { get; set; }
        public double Weight { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"License Plate: {LicensePlate}");
            sb.AppendLine($"Horse Power: {HorsePower}");
            sb.Append($"Weight: {Weight}");
            return sb.ToString();

        }

    }
}
