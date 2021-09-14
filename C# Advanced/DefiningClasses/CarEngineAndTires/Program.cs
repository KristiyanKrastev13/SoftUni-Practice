using System;

namespace CarManufacturer
{
     public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new Tire[4]
            {
               new Tire(2005, 2.2),
               new Tire(2005, 2.2),
               new Tire(2005, 2.2),
               new Tire(2005, 2.2)

            };

            var engine = new Engine(2000, 3.8);

            Car Lambo = new Car("Lamborgini", "Urus", 2020, 120, 14, engine, tires);
            Console.WriteLine();
        }
    }
}
