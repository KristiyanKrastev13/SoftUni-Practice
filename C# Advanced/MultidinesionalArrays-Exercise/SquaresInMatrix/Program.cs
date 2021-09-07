using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int counter = 0;

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] currChars = Console.ReadLine().Split().ToArray();
                
                for (int col = 0; col < cols; col++)
                {

                    matrix[row, col] = currChars[col];
                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols- 1; col++)
                {
                    string current = matrix[row, col];
                    if (current == matrix[row,col+1] && current == matrix[row+1, col] && current == matrix[row+1,col+1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);

        }
    }
}
