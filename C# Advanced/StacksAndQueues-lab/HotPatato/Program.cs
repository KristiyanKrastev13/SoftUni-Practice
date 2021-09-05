using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPatato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            Queue<string> kids = new Queue<string>(children);
            int n = int.Parse(Console.ReadLine());
            int patatoTosses = 0;

            while (kids.Count > 1)
            {
                string currentkid = kids.Dequeue();
                
                patatoTosses++;
                if (patatoTosses == n )
                {
                    patatoTosses = 0;
                    Console.WriteLine($"Removed {currentkid}");                   
                }
                else
                {
                    kids.Enqueue(currentkid);                   
                }
            }
            string winner = kids.Dequeue();
            Console.WriteLine($"Last is {winner}");
        }
    }
}
