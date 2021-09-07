using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            string[,] matrix = new string[rows, cols];
            string snake = Console.ReadLine();
            int snakeLetterPosition = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row == 0)
                {                   
                    for (int col = 0; col < cols; col++)
                    {
                        if (snakeLetterPosition == snake.Length)
                        {
                            snakeLetterPosition = 0;
                        }
                        string curr = snake[snakeLetterPosition].ToString();
                        matrix[row, col] = curr;
                        snakeLetterPosition++;
                    }
                }
                if (row % 2 != 0)
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        if (snakeLetterPosition == snake.Length)
                        {
                            snakeLetterPosition = 0;
                        }
                        string curr = snake[snakeLetterPosition].ToString();
                        matrix[row, col] = curr;
                        snakeLetterPosition++;
                    }
                }
                if (row % 2 == 0 && row != 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (snakeLetterPosition == snake.Length)
                        {
                            snakeLetterPosition = 0;
                        }
                        string curr = snake[snakeLetterPosition].ToString();
                        matrix[row, col] = curr;
                        snakeLetterPosition++;
                    }
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
