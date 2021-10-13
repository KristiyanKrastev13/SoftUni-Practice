using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];

            for (int col = 0; col < n; col++)
            {
                int[] currCol = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int rows = 0; rows < currCol.Length; rows++)
                {
                    if (rows == 0)
                    {
                        matrix[col] = new int[currCol.Length];
                    }
                    
                    matrix[col][rows] = currCol[rows];
                }
            }
            string[] command = Console.ReadLine().Split().ToArray();
            while (command[0] != "END")
            {
                int col = int.Parse(command[1]);
                int row = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                if (row < 0 || col < 0)
                {
                    Console.WriteLine($"Invalid coordinates");
                }
                else
                {
                    if (command[0] == "Add")
                    {
                        if (col <= n - 1 && row <= matrix[col].Length - 1 && col >= 0 && row >= 0)
                        {
                            matrix[col][row] += value;
                        }
                        else
                        {
                            Console.WriteLine($"Invalid coordinates");
                        }
                    }

                    if (command[0] == "Subtract")
                    {
                        if (col <= n - 1 && row <= matrix[col].Length - 1 && col >= 0 && row >= 0)
                        {
                            matrix[col][row] -= value;
                        }
                        else
                        {
                            Console.WriteLine($"Invalid coordinates");
                        }
                    }
                }
                

                command = Console.ReadLine().Split().ToArray();
            }

            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < matrix[col].Length; row++)
                {
                    Console.Write($"{matrix[col][row]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
