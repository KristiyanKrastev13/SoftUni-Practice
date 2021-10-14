using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            string[,] matrix = new string[rows, cols];
            string snake = Console.ReadLine();
            int currIndex = 0;

            for (int row = 0; row < rows; row++)
            {
                if (currIndex >= snake.Length)
                {
                    currIndex = 0;
                }
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snake[currIndex].ToString();
                        if (currIndex >= snake.Length -1)
                        {
                            currIndex = 0;
                        }
                        else
                        {
                            currIndex++;
                        }                       
                    }
                }
                else
                {
                    for (int col = cols -1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[currIndex].ToString();
                        if (currIndex >= snake.Length - 1)
                        {
                            currIndex = 0;
                        }
                        else
                        {
                            currIndex++;
                        }
                    }
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row,col]}");
                }
                Console.WriteLine();

            }

        }
    }
}
