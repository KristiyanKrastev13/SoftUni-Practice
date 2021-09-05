using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reversed = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                reversed.Push(input[i]);

            }
            foreach (var item in reversed)
            {
                Console.Write(item);
            }
        }
    }
}
