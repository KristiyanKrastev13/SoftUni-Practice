using System;
using System.Linq;

namespace MatrixShuffuling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            string[,] matrix = new string[rows, cols];
            

            for (int row = 0; row < rows; row++)
            {
                string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            string command = Console.ReadLine();
            while (command != "END")
            {
                
                string[] actions = command.Split().ToArray();
                if (actions.Length != 5 || actions[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    if (actions[0] == "swap")
                    {
                        int row1 = int.Parse(actions[1]);
                        int col1 = int.Parse(actions[2]);
                        int row2 = int.Parse(actions[3]);
                        int col2 = int.Parse(actions[4]);
                        if (row1 < rows && row2 < rows && col1 < cols && col2 < cols && row1 >= 0 && row2 >= 0 && col1 >= 0 && col2 >= 0)
                        {
                            string first = matrix[row1, col1];
                            string second = matrix[row2, col2];
                            matrix[row1, col1] = second;
                            matrix[row2, col2] = first;

                            for (int row = 0; row < rows; row++)
                            {
                                for (int col = 0; col < cols; col++)
                                {
                                    Console.Write($"{matrix[row,col]} ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                
                }
                command = Console.ReadLine();

            }
        }
    }
}
