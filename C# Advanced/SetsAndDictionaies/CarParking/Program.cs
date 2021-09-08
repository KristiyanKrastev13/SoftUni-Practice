using System;
using System.Collections.Generic;
using System.Linq;

namespace CarParking
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();

            string command = Console.ReadLine();

            while(command != "END")
            {
                string[] splitet = command.Split(", ").ToArray();
                if (splitet[0] == "IN")
                {
                    carNumbers.Add(splitet[1]);
                }
                if (splitet[0] == "OUT")
                {
                    carNumbers.Remove(splitet[1]);
                }
                command = Console.ReadLine();
            }
            if (carNumbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in carNumbers)
                {

                    Console.WriteLine(item);
                }
            }
        }
    }
}
