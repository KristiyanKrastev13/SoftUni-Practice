using System;


namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            long[][] matrix = new long[n][];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < row +1; col++)
                {
                    if (col == 0)
                    {
                        matrix[row] = new long[row + 1];
                    }
                    matrix[row][col] = 1;                    
                }
            }

            for (int row = 2; row < n; row++)
            {
                for (int col = 1; col < row ; col++)
                {
                                     
                        matrix[row][col] = matrix[row - 1][col- 1] + matrix[row - 1][col];                  
                }
            }
            if (n > 2)
            {
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < row + 1; col++)
                    {
                        Console.Write($"{matrix[row][col]} ");

                    }
                    Console.WriteLine();
                }
            }
            if (n == 1)
            {
                Console.WriteLine($"1");
            }
            if (n == 2)
            {
                Console.WriteLine("1");
                Console.WriteLine("1 1");
            }
            


        }
    }
}
