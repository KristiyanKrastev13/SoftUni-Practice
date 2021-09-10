using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> uniqueChemicals = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] chemicals = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int k = 0; k < chemicals.Length; k++)
                {
                    uniqueChemicals.Add(chemicals[k]);
                }
            }

            foreach (var chemical in uniqueChemicals)
            {
                Console.Write(chemical + " ");
            }
        }
    }
}
