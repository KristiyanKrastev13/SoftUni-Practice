using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            char[,] matrix = new char[rows, cols];
            int squaresCounter = 0;

            for (int row = 0; row < rows; row++)
            {
                char[] letters = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = letters[col];
                }
            }

            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    char current = matrix[row, col];
                    if (current == matrix[row, col+1] && current == matrix[row+1,col] && current == matrix[row+1,col+1])
                    {
                        squaresCounter++;
                    }
                }
            }
            if (squaresCounter == 0)
            {
                Console.WriteLine($"0");
            }
            else
            {
                Console.WriteLine($"{squaresCounter}");
            }
            
            
        }
    }
}
