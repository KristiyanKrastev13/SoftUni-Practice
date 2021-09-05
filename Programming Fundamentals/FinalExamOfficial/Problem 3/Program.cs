using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(":").ToArray();
            Dictionary<string, int> PersonAndHealth = new Dictionary<string, int>();
            Dictionary<string, int> PersonAndEnergy = new Dictionary<string, int>();

            while (commands[0] != "Results")
            {
                string action = commands[0];
                if (action == "Add")
                {
                    string name = commands[1];
                    int health = int.Parse(commands[2]);
                    int energy = int.Parse(commands[3]);
                    if (!PersonAndHealth.ContainsKey(name))
                    {
                        PersonAndHealth.Add(name, health);
                        PersonAndEnergy.Add(name, energy);
                    }
                    else
                    {
                        PersonAndHealth[name] += health;
                    }
                }
                else if (action == "Attack")
                {
                    string atacker = commands[1];
                    string defender = commands[2];
                    int damage = int.Parse(commands[3]);
                    if (PersonAndHealth.ContainsKey(atacker) && PersonAndHealth.ContainsKey(defender))
                    {
                        PersonAndHealth[defender] -= damage;
                        PersonAndEnergy[atacker] -= 1;
                        if (PersonAndHealth[defender] <= 0)
                        {
                            Console.WriteLine($"{defender} was disqualified!");
                            PersonAndEnergy.Remove(defender);
                            PersonAndHealth.Remove(defender);
                        }
                        if (PersonAndEnergy[atacker] <= 0)
                        {
                            Console.WriteLine($"{atacker} was disqualified!");
                            PersonAndEnergy.Remove(atacker);
                            PersonAndHealth.Remove(atacker);
                        }
                    }
                }
                if (action == "Delete")
                {
                    if (commands[1] == "All")
                    {
                        PersonAndHealth.Clear();
                        PersonAndEnergy.Clear();
                    }
                    else
                    {
                        string name = commands[1];
                        if (PersonAndHealth.ContainsKey(name))
                        {
                            PersonAndHealth.Remove(name);
                            PersonAndEnergy.Remove(name);
                        }
                    }
                }
               commands = Console.ReadLine().Split(":").ToArray();
            }
            Console.WriteLine($"People count: {PersonAndHealth.Count}");

            PersonAndHealth = PersonAndHealth.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in PersonAndHealth)
            {
                Console.WriteLine($"{item.Key} - {item.Value} - {PersonAndEnergy[item.Key]}");
            }
        }
    }
}

