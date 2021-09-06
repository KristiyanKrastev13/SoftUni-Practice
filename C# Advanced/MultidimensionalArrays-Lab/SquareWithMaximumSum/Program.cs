using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows =  size[0];
            int cols = size[1];
            int[,] matrix = new int[size[0], size[1]];
            for (int row = 0; row < size[0]; row++)
            {
                int[] curr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < size[1]; col++)
                {
                    int currnumb = curr[col];
                    matrix[row, col] = currnumb;                    
                }
            }
            int maxsum = int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;

            for (int row = 0; row < rows -1; row++)
            {              
                for (int col = 0; col < cols -1; col++)
                {
                    int currentSquare = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSquare > maxsum)
                    {
                        maxsum = currentSquare;
                        maxSumRow = row;
                        maxSumCol = col;
                    }                   
                }
            }
            for (int row = maxSumRow; row < maxSumRow + 2; row++)
            {
                for (int col = maxSumCol; col < maxSumCol+2; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxsum);
        }
    }
}
