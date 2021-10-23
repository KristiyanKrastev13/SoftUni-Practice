using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> scarfs = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> sets = new Queue<int>();
            int bestSet = 0;

            while (hats.Count != 0 && scarfs.Count != 0)
            {
                int currHat = hats.Peek(); ;
                int currScarf = scarfs.Peek();
                if (currHat > currScarf)
                {
                    int createSet = currScarf + currHat;
                    sets.Enqueue(createSet);
                    if (createSet > bestSet)
                    {
                        bestSet = createSet;
                    }
                    hats.Pop();
                    scarfs.Dequeue();
                    
                    
                }
                if (currHat < currScarf)
                {
                    hats.Pop();
                    continue;
                }
                if (currHat == currScarf)
                {
                    scarfs.Dequeue();
                    int hatIncrement = hats.Pop() + 1;
                    hats.Push(hatIncrement);
                }

            }
            Console.WriteLine($"The most expensive set is: {bestSet}");
            Console.WriteLine(String.Join(" ", sets));
        }
    }
}
