using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemThree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Stack<string> stack = new Stack<string>(input.Reverse());

            while (stack.Count != 1)
            {
                int first = int.Parse(stack.Pop());
                string sign = stack.Pop();
                int second = int.Parse(stack.Pop());
                int result = GetResult(first, sign, second);
                stack.Push(result.ToString());
            }
            Console.WriteLine(stack.Pop());
        }
        static int GetResult(int first, string sign, int second)
        {
            if (sign == "+")
            {
               return first + second;

            }
            else
            {
               return  first - second;
            }
            
        }
    }
}
