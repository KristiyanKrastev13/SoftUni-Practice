using System;
using System.Linq;

namespace SumMatrix
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
                int[] current = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int row = 0; row < rows; row++)
                {
                    matrix[col, row] = current[row];
                }
            }
            int sum = 0;
            Console.WriteLine(cols);
            Console.WriteLine(rows);
            Console.WriteLine(GetSum(matrix, cols, rows));
        }

        public static int GetSum(int[,] matrix, int cols, int rows)
        {
            int sum = 0;
            for (int col = 0; col < cols; col++)
            {
                
                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[col, row];
                }
            }

            return sum;
        }
    }
}
