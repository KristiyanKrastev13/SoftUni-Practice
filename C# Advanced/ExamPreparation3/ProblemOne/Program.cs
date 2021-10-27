using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());
            List<int> defence = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> orcsLeft = new List<int>();
            int waveCount = 0;
            

            while (waves > 0 && defence.Count != 0)
            {
                waveCount++;
                waves--;

                List<int> orcs = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
                if (waveCount == 3)
                {
                    int defenceToAdd = int.Parse(Console.ReadLine());
                    defence.Add(defenceToAdd);
                    waveCount = 0;
                }
                while (orcs.Count != 0)
                {
                    int currOrc = orcs[0];
                    int CurrDefence = defence[0];
                    if (CurrDefence > currOrc)
                    {
                        orcs.RemoveAt(0);
                        defence[0] = CurrDefence - currOrc;
                    }
                  else  if (CurrDefence < currOrc)
                    {
                        defence.RemoveAt(0);
                        orcs[0] = currOrc - CurrDefence;
                    }
                  else  if (currOrc == CurrDefence)
                    {
                        orcs.RemoveAt(0);
                        defence.RemoveAt(0);
                    }
                    if (defence.Count == 0)
                    {
                        orcsLeft = orcs;
                        break;
                    }
                }                           
            }
            if (defence.Count > 0)
            {
                Console.WriteLine($"The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {String.Join(", ", defence)}");
            }
            else
            {
                Console.WriteLine($"The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {String.Join(", ", orcsLeft)}");
            }
        }
    }
}
