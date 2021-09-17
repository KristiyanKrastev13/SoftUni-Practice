using System;
using System.Collections.Generic;
using System.Linq;

namespace CarAndCargo
{
   public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] car = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = car[0];
                double engineSpeed = double.Parse(car[1]);
                double enginePower = double.Parse(car[2]);
                Engine engine = new Engine(engineSpeed, enginePower);
                double cargoWeight = double.Parse(car[3]);
                string cargoType = car[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tire tireOne = new Tire(double.Parse(car[5]), double.Parse(car[6]));
                Tire tireTwo = new Tire(double.Parse(car[7]), double.Parse(car[8]));
                Tire tireThree = new Tire(double.Parse(car[9]), double.Parse(car[10]));
                Tire tireFour = new Tire(double.Parse(car[11]), double.Parse(car[12]));
                Tire[] currTyres = new Tire[4];
                currTyres[0] = tireOne;
                currTyres[1] = tireTwo;
                currTyres[2] = tireThree;
                currTyres[3] = tireFour;

                Car currCar = new Car(model, engine, cargo, currTyres);

                cars.Add(currCar);
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                cars = cars.Where(x => x.Cargo.CargoType == "fragile").Where(t => t.Tires.Any(ct => ct.TirePresure <= 1)).ToList();
            }
            if (command == "flammable")
            {
                cars = cars.Where(x => x.Cargo.CargoType == "flammable").Where(e => e.Engine.EnginePower > 250).ToList();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}");
            }


           
        }
    }
}
