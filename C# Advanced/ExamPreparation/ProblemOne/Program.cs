using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingridiants = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            Stack<int> fressnes = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            int dippingSauce = 0;
            int greenSalad = 0;
            int chocolateCake = 0;
            int lobster = 0;

            while (ingridiants.Count != 0 && fressnes.Count != 0)
            {
                int currIngridiant = ingridiants.Peek();
                int currFreshness = fressnes.Peek();
                int sum = currFreshness * currIngridiant;
                if (currIngridiant == 0)
                {
                    ingridiants.Dequeue();
                    
                    continue;
                }
                if (sum == 150)
                {
                    dippingSauce++;
                    ingridiants.Dequeue();
                    fressnes.Pop();
                }
                else if (sum == 250)
                {
                    greenSalad++;
                    ingridiants.Dequeue();
                    fressnes.Pop();
                }
                else if (sum == 300)
                {
                    chocolateCake++;
                    ingridiants.Dequeue();
                    fressnes.Pop();
                }
                else if (sum == 400)
                {
                    lobster++;
                    ingridiants.Dequeue();
                    fressnes.Pop();
                }
                else
                {
                    fressnes.Pop();
                    int currIngridiantToChange = ingridiants.Dequeue();
                    currIngridiantToChange += 5;
                    ingridiants.Enqueue(currIngridiantToChange);
                }
                
            }
            if (dippingSauce > 0 && greenSalad > 0 && chocolateCake > 0 && lobster > 0)
            {
                Console.WriteLine($"Applause! The judges are fascinated by your dishes!");
                Console.WriteLine($"# Chocolate cake --> {chocolateCake}");
                Console.WriteLine($"# Dipping sauce --> {dippingSauce}");
                Console.WriteLine($"# Green salad --> {greenSalad}");
                Console.WriteLine($"# Lobster --> {lobster}");
            }
            else
            {
                Console.WriteLine($"You were voted off. Better luck next year.");
                if (ingridiants.Sum() > 0)
                {
                    Console.WriteLine($"Ingredients left: {ingridiants.Sum()}");
                }
                
                if (chocolateCake > 0)
                {
                    Console.WriteLine($"# Chocolate cake --> {chocolateCake}");
                }
                if (dippingSauce > 0)
                {
                    Console.WriteLine($"# Dipping sauce --> {dippingSauce}");
                }
                if (greenSalad > 0)
                {
                    Console.WriteLine($"# Green salad --> {greenSalad}");
                }
                if (lobster > 0)
                {
                    Console.WriteLine($"# Lobster --> {lobster}");
                }
            }
        }
    }
}
