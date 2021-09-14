using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Tire
    {
        public Tire(int year, double presure)
        {
            Year = year;
            Presure = presure;
        }
        public int Year { get; set; }

        public double Presure { get; set; }
    }
}
