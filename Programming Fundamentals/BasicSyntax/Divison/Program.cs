using System;

namespace Divison
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int biggestDivider = 0;

            for (int i = 2; i <= 10; i++)
            {
                int result = number % i;
                if (i == 2 || i == 3 || i == 6 || i == 7 || i == 10)
                {
                    if (result == 0)
                    {
                        biggestDivider = i;
                    }
                }
            }
            if (biggestDivider == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
Console.WriteLine($"The number is divisible by {biggestDivider}");
            }
            
        }
    }
}
