using System;
using System.Linq;

namespace SquareWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int cols = input[0];
            int rows = input[1];
            int[,] matrix = new int[cols, rows];
            int startIndexCol = 0;
            int startIndexRow = 0;
            int biggestSum = int.MinValue;
            
            for (int col = 0; col < cols; col++)
            {
                int[] current = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int row = 0; row < rows; row++)
                {
                    matrix[col, row] = current[row];
                }
            }

            for (int col = 0; col < cols-1; col++)
            {
                
                for (int row = 0; row < rows-1; row++)
                {
                    int currentSquare = matrix[col, row] + matrix[col, row + 1] + matrix[col + 1, row] + matrix[col + 1, row + 1];
                    if (currentSquare > biggestSum)
                    {
                        biggestSum = currentSquare;
                        startIndexCol = col;
                        startIndexRow = row;
                    }
                }
            }

            Console.WriteLine($"{matrix[startIndexCol,startIndexRow]} {matrix[startIndexCol,startIndexRow+ 1]} ");
            Console.WriteLine($"{matrix[startIndexCol +1 , startIndexRow]} {matrix[startIndexCol+ 1, startIndexRow + 1]} ");
            Console.WriteLine(biggestSum);


        }
    }
}
