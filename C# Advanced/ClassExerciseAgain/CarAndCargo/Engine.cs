using System;
using System.Collections.Generic;
using System.Text;

namespace CarAndCargo
{
    public class Engine
    {
        public Engine(double speed, double power)
        {
            EngineSpeed = speed;
            EnginePower = power;
        }
        public double EngineSpeed { get; set; }

        public double EnginePower { get; set; }
    }
}
