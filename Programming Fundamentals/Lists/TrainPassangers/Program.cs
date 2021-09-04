using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainPassangers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagoons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagoonsCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split().ToArray();
                
                if (tokens[0] == "Add")
                {
                    int currPassangers = int.Parse(tokens[1]);
                    wagoons.Add(currPassangers);

                }
                else
                {
                   int addPassangers = int.Parse(tokens[0]);
                    for (int i = 0; i < wagoons.Count; i++)
                    {
                        if (wagoons[i] + addPassangers <= wagoonsCapacity)
                        {
                            wagoons[i] += addPassangers;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", wagoons));

        }
    }
}
