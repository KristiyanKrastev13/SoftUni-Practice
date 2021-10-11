using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split().ToArray();
            Queue<string> players = new Queue<string>(kids);
            int tosses = int.Parse(Console.ReadLine());
            int counter = 0;

            while (players.Count != 1)
            {
                counter++;
                string kid = players.Dequeue();
                if (counter == tosses)
                {
                    Console.WriteLine($"Removed {kid}");
                    counter = 0;
                }
                else
                {
                    players.Enqueue(kid);
                }
            }
            Console.WriteLine($"Last is {players.Dequeue()}");
           
        }
    }
}
