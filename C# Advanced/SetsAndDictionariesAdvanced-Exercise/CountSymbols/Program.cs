using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> characterCount = new SortedDictionary<char, int>();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (!characterCount.ContainsKey(input[i]))
                {
                    characterCount.Add(input[i], 1);
                }
                else
                {
                    characterCount[input[i]]++;
                }
            }

            foreach (var item in characterCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
