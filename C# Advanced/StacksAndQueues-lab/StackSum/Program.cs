using System;
using System.Collections.Generic;
using System.Linq;


namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < array.Length; i++)
            {
                stack.Push(array[i]);
            }
            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] tokens = command.Split().ToArray();
                if(tokens[0] == "add")
                {
                    int firstNum = int.Parse(tokens[1]);
                    int secondNum = int.Parse(tokens[2]);
                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }
                else if (tokens[0] == "remove")
                {
                    int times = int.Parse(tokens[1]);
                    if (times <= stack.Count)
                    {
                        for (int i = 0; i < times; i++)
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
