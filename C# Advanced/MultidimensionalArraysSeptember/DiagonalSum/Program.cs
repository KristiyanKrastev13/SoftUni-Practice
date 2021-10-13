using System;
using System.Linq;

namespace DiagonalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            
            int[,] matrix = new int[input, input];
            for (int col = 0; col < input; col++)
            {
                int[] current = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int row = 0; row < input; row++)
                {
                    matrix[col, row] = current[row];
                }
            }
            int diagonalSum = 0;
            for (int col = 0; col < input; col++)
            {

                diagonalSum += matrix[col, col];
            }
            Console.WriteLine(diagonalSum);

        }
    }
}
