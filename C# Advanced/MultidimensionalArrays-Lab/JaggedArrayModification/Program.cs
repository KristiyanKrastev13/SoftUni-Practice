using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }

            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                var splitet = command.Split();
                int row = int.Parse(splitet[1]);
                int col = int.Parse(splitet[2]);
                int value = int.Parse(splitet[3]);

                if (row >= 0 && col >= 0 && row < n && col < n) 
                {
                    if (splitet[0] == "Add")
                    {
                        matrix[row, col] += value;
                    }
                    if (splitet[0] == "Subtract")
                    {
                        matrix[row, col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
                command = Console.ReadLine();

            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
