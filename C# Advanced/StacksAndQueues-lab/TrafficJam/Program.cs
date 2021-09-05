using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsPerGreen = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string command = Console.ReadLine();
            int counter = 0;

            while (command != "end")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                }
                else
                {
                    for (int i = 0; i < carsPerGreen; i++)
                    {
                        if (cars.Count >= 1)
                        {
                            string currCar = cars.Dequeue();
                            Console.WriteLine($"{currCar} passed!");
                            counter++;
                        }                       
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
