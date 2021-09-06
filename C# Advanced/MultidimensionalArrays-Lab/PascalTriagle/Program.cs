using System;
using System.Linq;

namespace PascalTriagle
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long[][] jagged = new long[n][];
            if (n == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    jagged[i] = new long[i + 1];
                }
                jagged[0][0] = 1;
                jagged[1][0] = 1;
                jagged[1][1] = 1;
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < row + 1; col++)
                    {
                        jagged[row][col] = 1;
                    }
                }
                if (n != 1 && n != 2)
                {
                    for (int row = 2; row < n; row++)
                    {
                        for (int col = 1; col < jagged[row].Length - 1; col++)
                        {
                            long first = jagged[row - 1][col - 1];
                            long second = jagged[row - 1][col];
                            long result = first + second;
                            jagged[row][col] = result;
                        }
                    }
                }
              
                   for (int row = 0; row < n; row++)
                   {
                       for (int col = 0; col < jagged[row].Length; col++)
                       {
                           Console.Write(jagged[row][col] + " ");
                       }
                       Console.WriteLine();
                   }
               
            }
                                  
        }
    }
}
