using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
   public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string model = input[0];
                double fuel = double.Parse(input[1]);
                double fuelconsumption = double.Parse(input[2]);

                Car currCar = new Car(model, fuel, fuelconsumption);
                cars.Add(currCar);
       
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] splited = command.Split();
                string carmodel = splited[1];
                double distance = double.Parse(splited[2]);
                if (splited[0] == "Drive")
                {
                    if (cars.Any(c => c.Model == carmodel))
                    {
                        Car car = cars.First(c => c.Model == carmodel);
                        car.CanDrive(distance);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var item in cars)
            {
                Console.WriteLine(item.ToString()); 
            }

        }
    }
}
