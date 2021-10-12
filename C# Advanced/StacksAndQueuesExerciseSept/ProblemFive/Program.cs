using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> allItems = new Stack<int>(clothes);
            int currentRackCapacity = rackCapacity;
            int stacks = 0;
            for (int i = 0; i < clothes.Length; i++)
            {
                if (i == 0 && allItems.Sum() != 0)
                {
                    stacks = 1;
                }
                int currentItem = allItems.Peek();
                if (currentRackCapacity - currentItem >= 0)
                {
                    currentRackCapacity -= currentItem;
                    allItems.Pop();
                }
                else
                {
                    stacks++;
                    currentRackCapacity = rackCapacity;
                    i--;
                }
            }
            Console.WriteLine(stacks);
        }
    }
}
