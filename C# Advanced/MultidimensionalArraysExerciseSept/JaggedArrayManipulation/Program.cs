using System;
using System.Linq;

namespace JaggedArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] matrix = new double[n][];
            for (int row = 0; row < n; row++)
            {
                double[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                for (int col = 0; col < input.Length; col++)
                {
                    if (col == 0)
                    {
                        matrix[row] = new double[input.Length];
                    }
                    matrix[row][col] = input[col];
                }
            }
            for (int row = 0; row < n -1; row++)
            {
                if (matrix[row].Length == matrix[row+1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2;
                        matrix[row+1][col] *= 2;
                    }
                }
                else
                {

                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] /= 2;
                        
                    }
                    for (int col = 0; col < matrix[row+1].Length; col++)
                    {
                        matrix[row+1][col] /= 2;
                    }
                }
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] actions = command.Split();
                string action = actions[0];
                int roww = int.Parse(actions[1]);
                int coll = int.Parse(actions[2]);
                int value = int.Parse(actions[3]);
                if (action == "Add" && roww >= 0)
                {
                    if (roww <= n && matrix[roww].Length -1 > coll && roww >= 0 && coll >= 0)
                    {
                        matrix[roww][coll] += value;
                    }
                }

                if (action == "Subtract" && roww >= 0)
                {
                    if (roww <= n && matrix[roww].Length - 1 >= coll && roww >= 0 && coll >= 0)
                    {
                        matrix[roww][coll] -= value;
                    }
                }
                command = Console.ReadLine();
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }
           
            
        }
    }
}
