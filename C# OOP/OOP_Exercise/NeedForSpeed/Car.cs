using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        private const double defaultConsumation = 3;
        public Car(int hp, double fuel) : base(hp, fuel)
        {
            DefaultFuelConsumption = defaultConsumation;
        }
    }
}
