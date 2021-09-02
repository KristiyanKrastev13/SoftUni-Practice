using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int TankCapacity = 255;
            int littersAdded = 0;
            for (int i = 0; i < n; i++)
            {
                int currentLiters = int.Parse(Console.ReadLine());
                if (TankCapacity >= currentLiters)
                {
                    TankCapacity -= currentLiters;
                    littersAdded += currentLiters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(littersAdded);
        }
    }
}
