using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> pieceAndComposer = new Dictionary<string, string>();
            Dictionary<string, string> pieceandKey = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('|').ToArray();
                pieceAndComposer.Add(input[0], input[1]);
                pieceandKey.Add(input[0], input[2]);
            }
            string[] commands = Console.ReadLine().Split('|').ToArray();

            while (commands[0] != "Stop")
            {
                string action = commands[0];
                string piece = commands[1];
                if (action == "Add")
                {
                    if (!pieceAndComposer.ContainsKey(piece))
                    {
                        string composer = commands[2];
                        string key = commands[3];
                        pieceAndComposer.Add(piece, composer);
                        pieceandKey.Add(piece, key);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    if (pieceAndComposer.ContainsKey(piece))
                    {
                        pieceAndComposer.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (action == "ChangeKey")
                {
                    if (pieceandKey.ContainsKey(piece))
                    {
                        string newKey = commands[2];
                        pieceandKey[piece] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                commands = Console.ReadLine().Split('|').ToArray();

            }
            pieceAndComposer = pieceAndComposer.OrderBy(x => x.Key).ThenBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in pieceAndComposer)
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value}, Key: {pieceandKey[item.Key]}");

            }


        }
    }
}
