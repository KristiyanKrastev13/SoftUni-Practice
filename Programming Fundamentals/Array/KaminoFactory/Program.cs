using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfArray = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int[] bestDna = new int[lenghtOfArray];
            int bestCount = 0;
            int bestStartIndex = 99;
            int[] secondDna = new int[lenghtOfArray];
            int secondStartIndex = 0;

            while (command != "Clone them")
            {
                int counter = 1;
                int currentBestindex = 0;
                int[] dna = command.Split('!').Select(int.Parse).ToArray();
                for (int i = 0; i <dna.Length - 1 ; i++)
                {
                    if (dna[i] == 1 && dna[i+1] == 1)
                    {
                        if (counter == 1)
                        {
                            currentBestindex = i;
                        }
                        counter++;                                           
                    }                  
                }
                if (counter > bestCount )
                {
                    bestCount = counter;
                    bestDna = dna;
                    bestStartIndex = currentBestindex;
                }
                if (counter == bestCount)
                {
                    if ()
                    {

                    }

                }
               

                command = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", bestDna));
                     
        }
    }
}
