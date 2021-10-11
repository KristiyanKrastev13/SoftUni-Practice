using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }

            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] action = command.Split();
                if (action[0] == "add")
                {
                    int first = int.Parse(action[1]);
                    int second = int.Parse(action[2]);
                    stack.Push(first);
                    stack.Push(second);
                }
                if (action[0] == "remove")
                {
                    int itemsToRemove = int.Parse(action[1]);
                    if (stack.Count >= itemsToRemove)
                    {
                        for (int i = 0; i < itemsToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                    
                }
                command = Console.ReadLine().ToLower();
            }
            int result = stack.Sum();
            Console.WriteLine($"Sum: {result}");

        }
    }
}
