using System;

namespace SymbolInMaxtix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            bool found = false;

            for (int col = 0; col < n; col++)
            {
                string input = Console.ReadLine();
                char[] chars = input.ToCharArray();
                
                for (int row = 0; row < n; row++)
                {
                    matrix[col, row] = chars[row];
                }
            }
            char symbol = char.Parse(Console.ReadLine());

            for (int col = 0; col < n; col++)
            {
                
                for (int row = 0; row < n; row++)
                {
                    if (matrix[col,row] == symbol)
                    {
                        Console.WriteLine($"({col}, {row})");
                        found = true;
                        break;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }


        }
    }
}
