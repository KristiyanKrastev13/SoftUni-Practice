using System;

namespace CarManufacturer
{
     public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "BMW";
            car.Model = "E82";
            car.Year = 2008;

            Console.WriteLine($"This car is a {car.Make} model {car.Model} made int {car.Year}");

        }
    }
}
