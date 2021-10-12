using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemEight
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputSplitted = input.ToCharArray();
            Stack<char> stack = new Stack<char>(inputSplitted);
            Queue<char> queue = new Queue<char>(inputSplitted);
            bool same = true;
            for (int i = 0; i < inputSplitted.Length / 2; i++)
            {
                char first = stack.Pop();
                char second = queue.Dequeue();
                if (first == ')' && second == '(')
                {
                    continue;
                }
               
                if (first == ']' && second == '[')
                {
                    continue;
                }
                
                if (first == '}' && second == '{')
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"NO");
                    same = false;
                    break;
                }
            }
            if (same)
            {
                Console.WriteLine($"YES");
            }
        }
    }
}
