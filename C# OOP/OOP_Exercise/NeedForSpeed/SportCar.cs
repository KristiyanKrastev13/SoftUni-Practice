using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public SportCar(int hp, double fuel) : base(hp, fuel)
        {
            DefaultFuelConsumption = 10;
        }
    }
}
