using System;
using System.Collections.Generic;

namespace ProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> text = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                text.Push(input[i]);
               
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(text.Pop());
            }

           
        }
    }
}
