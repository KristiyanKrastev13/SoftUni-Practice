using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacities = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] bottleCapacities = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> bottles = new Stack<int>(bottleCapacities);
            Queue<int> cups = new Queue<int>(cupsCapacities);
            int waterWasted = 0;
            bool bottlesLeft = true;

            while (cups.Count != 0 || bottles.Count == 0)
            {
                if (bottles.Count == 0)
                {
                    bottlesLeft = false;
                    break;
                }
                int currentCup = cups.Dequeue();
                int currentBottle = bottles.Pop();
                if (currentBottle >= currentCup)
                {
                    
                    int wastedWaterNow = currentBottle - currentCup;
                    waterWasted += wastedWaterNow;
                }
                else
                {
                    
                    if (bottles.Count == 0)
                    {
                        bottlesLeft = false;
                        waterWasted += currentBottle;
                        cups.Enqueue(currentCup);
                        break;
                    }
                    currentCup -= currentBottle;
                    int nextBottle = bottles.Pop();
                    int wastedSecondBottle = nextBottle - currentCup;
                    waterWasted += wastedSecondBottle;
                }
            }

            if (bottlesLeft)
            {
                Console.Write($"Bottles: ");
                while (bottles.Count != 0)
                {
                    Console.Write($"{bottles.Pop()}");
                }
                Console.WriteLine();
                Console.WriteLine($"Wasted litters of water: {waterWasted}");
            }
            else
            {
                Console.Write($"Cups: ");
                while (cups.Count != 0)
                {
                    Console.Write($"{cups.Dequeue()} ");
                }
                Console.WriteLine();
                Console.WriteLine($"Wasted litters of water: {waterWasted}");
            }
        }
    }
}
