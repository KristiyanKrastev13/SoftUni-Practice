using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
  public  class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<BaseHero> heros = new List<BaseHero>();
            while (heros.Count != n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                if (type != "Druid" && type != "Warrior" && type != "Paladin" && type != "Rogue")
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }
                else
                {
                    if (type == "Druid")                   
                        heros.Add(new Druid(name));
                    if (type == "Paladin")
                        heros.Add(new Paladin(name));
                    if (type == "Rogue")
                        heros.Add(new Rogue(name));
                    if (type == "Warrior")
                        heros.Add(new Warrior(name));
                }
                
            }
            int bossPower = int.Parse(Console.ReadLine());
            int totalPower = 0;
            foreach (var hero in heros)
            {
                Console.WriteLine(hero.CastAbility());
                totalPower += hero.Power;
            }
            if (totalPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
