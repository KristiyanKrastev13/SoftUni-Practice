﻿using System;

namespace NeedForSpeed
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            RaceMotorcycle motorcycle = new RaceMotorcycle(100, 100);
            motorcycle.Drive(10);
            Console.WriteLine(motorcycle.Fuel);
        }
    }
}
