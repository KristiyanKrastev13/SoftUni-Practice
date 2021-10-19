using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            Queue<int> secondBox = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse).Reverse());
            int items = 0;
            
            while(firstBox.Count > 0 && secondBox.Count > 0)
            {
                int firstItem = firstBox.Peek();
                int secondItem = secondBox.Peek();
                if ((firstItem + secondItem) % 2 == 0)
                {
                    items += (firstItem + secondItem);
                    firstBox.Dequeue();
                    secondBox.Dequeue();
                }
                else
                {
                    firstBox.Enqueue(secondItem);
                    secondBox.Dequeue();
                }
            }
            if (firstBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (items >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {items}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {items}");
            }
        }
    }
}
