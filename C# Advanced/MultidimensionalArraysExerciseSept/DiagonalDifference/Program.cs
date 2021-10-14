using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int sumNomrlaDiagonal = 0;
            int sumReversedDiagonal = 0;

            for (int row = 0; row < n; row++)
            {
                int[] currentCol = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentCol[col];
                }
            }

            for (int i = 0; i < n; i++)
            {
                int curr = matrix[i, i];
                sumNomrlaDiagonal += curr;
            }

            for (int row = 0; row < n; row++)
            {
                int curr = matrix[row, n - 1 - row];
                sumReversedDiagonal += curr;
            }
            int result = Math.Abs(sumNomrlaDiagonal - sumReversedDiagonal);
            Console.WriteLine(result);
        }
    }
}
