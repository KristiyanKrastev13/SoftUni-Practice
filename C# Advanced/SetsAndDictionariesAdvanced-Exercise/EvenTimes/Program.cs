using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<int> set = new HashSet<int>();
            int copyNumber = 0;

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (set.Contains(current))
                {
                    copyNumber = current;
                }
                set.Add(current);
                
            }
            Console.WriteLine(copyNumber);
        }
    }
}
