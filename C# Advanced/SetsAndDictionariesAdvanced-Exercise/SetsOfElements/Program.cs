using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];

            HashSet<int> setOne = new HashSet<int>();
            HashSet<int> setTwo = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                setOne.Add(current);
            }
            for (int i = 0; i < m; i++)
            {
                int current = int.Parse(Console.ReadLine());
                setTwo.Add(current);
            }
            
              foreach (var item in setOne)
              {
                int currentNumber = item;
                if (setTwo.Contains(currentNumber))
                {
                    Console.Write(currentNumber + " ");
                }
              }           
        }
    }
}
