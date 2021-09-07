using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int biggestSum = int.MinValue;
            int biggestRow = 0;
            int biggestCol = 0;
            if (rows > 3 || cols > 3)
            {
                int[,] matrix = new int[rows, cols];


                for (int row = 0; row < rows; row++)
                {
                    int[] currChars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = currChars[col];
                    }
                }
                for (int row = 0; row < rows - 2; row++)
                {
                    int currSum = 0;
                    for (int col = 0; col < cols - 2; col++)
                    {
                        currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                        if (currSum > biggestSum)
                        {
                            biggestSum = currSum;
                            biggestRow = row;
                            biggestCol = col;
                        }
                    }
                }
                Console.WriteLine($"Sum = {biggestSum}");
                for (int row = biggestRow; row < biggestRow + 3; row++)
                {
                    for (int col = biggestCol; col < biggestCol + 3; col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    Console.WriteLine();
                }
            }
          
        }
    }
}
