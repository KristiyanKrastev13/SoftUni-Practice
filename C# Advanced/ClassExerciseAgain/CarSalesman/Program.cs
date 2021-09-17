using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
   public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] engineData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (engineData.Length == 2)
                {
                    string model = engineData[0];
                    int power = int.Parse(engineData[1]);
                    Engine engine = new Engine(model, power);
                    engines.Add(engine);
                }
                if (engineData.Length == 3)
                {
                    string model = engineData[0];
                    int power = int.Parse(engineData[1]);
                    string displacemet = engineData[2];
                    Engine engine = new Engine(model, power, displacemet);
                    engines.Add(engine);
                }
                if (engineData.Length == 4)
                {
                    string model = engineData[0];
                    int power = int.Parse(engineData[1]);
                    string displacemet = engineData[2];
                    string efficenci = engineData[3];
                    Engine engine = new Engine(model, power, displacemet, efficenci);
                    engines.Add(engine);
                }                
            }
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                
                string[] carsData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carsData[0];
                string engineNeeded = carsData[1];
                Engine currEngine = engines.FirstOrDefault(x => x.Model == engineNeeded);
                if (carsData.Length == 2)
                {
                    Car currCar = new Car(model, currEngine);
                    cars.Add(currCar);                 
                }
                if (carsData.Length == 3)
                {
                    int nn;
                    bool isNumeric = int.TryParse(carsData[2], out nn);
                    if (nn != 0)
                    {
                        int weight = int.Parse(carsData[2]);
                        Car currCar = new Car(model, currEngine, weight);
                        cars.Add(currCar);
                    }
                    else
                    {
                        string color = carsData[2];
                        Car currCar = new Car(model, currEngine, color);
                        cars.Add(currCar);
                    }

                    
                    
                }
                if (carsData.Length == 4)
                {
                    int weight = int.Parse(carsData[2]);
                    string color = carsData[3];
                    Car currCar = new Car(model, currEngine, weight, color);
                    cars.Add(currCar);

                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
            
        }
        
    }
}
