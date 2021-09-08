using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();

            string command = Console.ReadLine();

            while (command != "PARTY")
            {
                guests.Add(command);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "END")
            {
                guests.Remove(command);

                command = Console.ReadLine();
            }

            Console.WriteLine(guests.Count);

            guests = guests.OrderByDescending(g => char.IsDigit(g[0]))
                .ToHashSet();

            Console.WriteLine(string.Join(Environment.NewLine, guests));
        }
    }
}
