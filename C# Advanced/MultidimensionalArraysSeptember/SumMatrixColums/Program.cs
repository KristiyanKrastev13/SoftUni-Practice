using System;
using System.Linq;

namespace SumMatrixColums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int cols = input[0];
            int rows = input[1];
            int[,] matrix = new int[cols, rows];
            for (int col = 0; col < cols; col++)
            {
                int[] current = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int row = 0; row < rows; row++)
                {
                    matrix[col, row] = current[row];
                }
            }

            for (int row = 0; row < rows; row++)
            {
                int currSum = 0;
                for (int col = 0; col < cols; col++)
                {
                    currSum += matrix[col, row];
                }
                Console.WriteLine(currSum);
            }
        }
    }
}
