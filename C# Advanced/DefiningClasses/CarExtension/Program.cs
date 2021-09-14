using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "Bmw";
            car.Model = "E82";
            car.Year = 2008;
            car.FuelConsumption = 100;
            car.FuelQuantity = 200;

            Console.WriteLine(car.WhoAmI());

           


        }
    }
}
