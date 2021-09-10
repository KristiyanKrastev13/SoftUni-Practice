using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string,int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();
                string color = input[0];
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                string[] clothers = input[1].Split(",").ToArray();
                for (int k = 0; k < clothers.Length; k++)
                {
                    if (!wardrobe[color].ContainsKey(clothers[k]))
                    {
                        wardrobe[color].Add(clothers[k], 1);
                    }
                    else
                    {
                        wardrobe[color][clothers[k]]++;
                    }
                }
            }

            string[] selection = Console.ReadLine().Split().ToArray();
            string colorPick = selection[0];
            string piecePick = selection[1];
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var piece in color.Value)
                {
                    if (color.Key == colorPick && piece.Key == piecePick)
                    {
                        Console.WriteLine($"* {piece.Key} - {piece.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {piece.Key} - {piece.Value}");
                    }                   
                }
            }         
        }
    }
}
