using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] square = new int[n, n];
            int diagonalOne = 0;
            int diagonalTwo = 0;

            for (int row = 0; row < n; row++)
            {
                int[] currRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    square[row, col] = currRow[col];
                }
            }
            for (int row = 0; row < n; row++)
            {
                diagonalOne += square[row, row];
            }
            for (int row = 0; row < n; row++)
            {
                            
                 diagonalTwo += square[row, n - row - 1];              
            }

            int result = Math.Abs(diagonalOne - diagonalTwo);
            Console.WriteLine(result);
        }    
    }
}
