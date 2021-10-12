using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            Queue<string> playlist = new Queue<string>(input);
            
            while (playlist.Count != 0)
            {
                string commands = Console.ReadLine();
                string[] command = commands.Split();
                if (command[0] == "Add")
                {
                    string songName = commands.Substring(4);
                    if (!playlist.Contains(songName))
                    {
                        playlist.Enqueue(songName);
                    }
                    else
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                }
                if (command[0] == "Show")
                {
                    Queue<string> copy = new Queue<string>(playlist);
                    while (copy.Count != 1)
                    {
                        Console.Write($"{copy.Dequeue()}, ");
                    }
                    Console.Write($"{copy.Dequeue()}");
                    Console.WriteLine();
                }
                if (command[0] == "Play")
                {
                    if (playlist.Count == 0)
                    {
                        Console.WriteLine($"No more songs!");
                        break;
                    }
                    else
                    {
                        playlist.Dequeue();
                    }

                }
            }
            Console.WriteLine($"No more songs!");
        }
    }
}
