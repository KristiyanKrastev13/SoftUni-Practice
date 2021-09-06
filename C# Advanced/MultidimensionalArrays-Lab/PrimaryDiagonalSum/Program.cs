using System;
using System.Linq;

namespace SumMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int diagonalSum = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] curr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = curr[cols];

                }
            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
             
                    diagonalSum += matrix[rows, rows];            
                
            }

            Console.WriteLine(diagonalSum);

        }
    }
}
