using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int stackSize = parameters[0];
            int elementsToRemove = parameters[1];
            int elementToSeek = parameters[2];
            Queue<int> stack = new Queue<int>();
            bool foundItem = false;
            int smallestElement = int.MaxValue;

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                stack.Enqueue(numbers[i]);
            }
            for (int i = 0; i < elementsToRemove; i++)
            {
                stack.Dequeue();
            }
            for (int i = 0; i < stack.Count; i++)
            {
                int current = stack.Dequeue();

                if (current == elementToSeek)
                {
                    Console.WriteLine($"true");
                    foundItem = true;
                    break;
                }

                if (current < smallestElement)
                {
                    smallestElement = current;
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine($"0");
            }
            if (stack.Count != 0 && foundItem == false)
            {

                Console.WriteLine($"{smallestElement}");

            }
        }
    }
}
