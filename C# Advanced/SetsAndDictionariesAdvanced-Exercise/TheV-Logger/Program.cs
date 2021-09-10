using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> vloggersFollowers = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> vloggersFollowing = new Dictionary<string, List<string>>();
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            
           
            while (command[0] != "Statistics")
            {
                string currentVlogger = command[0];
                string action = command[1];
                if (action == "joined")
                {
                    if (!vloggersFollowers.ContainsKey(currentVlogger))
                    {
                        bool validName = true;
                        for (int i = 0; i < currentVlogger.Length; i++)
                        {
                            if (Char.IsWhiteSpace(currentVlogger[i]) || char.IsDigit(currentVlogger[i]))
                            {
                                validName = false;
                            }
                        }
                        if (validName)
                        {
                            vloggersFollowers.Add(currentVlogger, new List<string>());
                            vloggersFollowing.Add(currentVlogger, new List<string>());
                        }
                        validName = true;
                        
                    }
                }
                if (action == "followed")
                {
                    string followed = command[2];
                    if (vloggersFollowing.ContainsKey(currentVlogger) && vloggersFollowing.ContainsKey(followed))
                    {
                        if (currentVlogger != followed)
                        {
                            if (!vloggersFollowers[followed].Contains(currentVlogger))
                            {
                                vloggersFollowers[followed].Add(currentVlogger);
                            }
                            if (!vloggersFollowing[currentVlogger].Contains(followed))
                            {
                                vloggersFollowing[currentVlogger].Add(followed);
                            }
                        }
                       
                        
                    }
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            vloggersFollowers = vloggersFollowers.OrderByDescending(x => x.Value.Count).ToDictionary(k => k.Key, v => v.Value);
            
            Console.WriteLine($"The V-Logger has a total of {vloggersFollowers.Count} vloggers in its logs.");
            int counter = 1;

            foreach (var vlogger in vloggersFollowers)
            {
                
                Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value.Count} followers, {vloggersFollowing[vlogger.Key].Count} following");
                if (counter == 1)
                {
                    vlogger.Value.Sort();
                    foreach (var item in vlogger.Value)
                    {
                        Console.WriteLine($"* {item}");
                    }
                }
               
                counter++;
            }
            
        }
    }
}
