using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemFour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(') 
                {
                    indexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    if (indexes.Any())
                    {
                        int startIndex = indexes.Pop();
                        int currentIndex = i;
                        string current = input.Substring(startIndex, currentIndex - startIndex + 1) ;
                        Console.WriteLine(current);
                    }
                }

            }

        }
    }
}
