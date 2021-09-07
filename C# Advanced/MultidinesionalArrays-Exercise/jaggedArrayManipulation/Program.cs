using System;
using System.Linq;

namespace jaggedArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] array = new double[rows][];
            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                array[row] = new double[numbers.Length];
                for (int col = 0; col < numbers.Length; col++)
                {
                    array[row][col] = numbers[col];
                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (array[row].Length == array[row + 1].Length)
                {
                    for (int col = 0; col < array[row].Length; col++)
                    {
                        double curr = array[row][col] * 2;
                        array[row][col] = curr;
                        double currTwo = array[row + 1][col] * 2;
                        array[row + 1][col] = currTwo;
                    }
                }
                if (array[row].Length != array[row + 1].Length)
                {
                    for (int col = 0; col < array[row].Length; col++)
                    {
                        double curr = array[row][col] / 2;
                        array[row][col] = curr;
                        
                    }
                    for (int col = 0; col < array[row+1].Length; col++)
                    {
                        double curr = array[row+1][col] / 2;
                        array[row+1][col] = curr;
                    }
                }
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] tokes = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (tokes[0] == "Add")
                {
                    int row = int.Parse(tokes[1]);
                    int col = int.Parse(tokes[2]);
                    double value = double.Parse(tokes[3]);
                    if (row < array.GetLength(0) && row >= 0 && array[row].Length > col && col >= 0)
                    {
                        double currValue = array[row][col];
                        array[row][col] = currValue + value;
                    }
                }
                 if (tokes[0] == "Subtract")
                {
                    int row = int.Parse(tokes[1]);
                    int col = int.Parse(tokes[2]);
                    double value = double.Parse(tokes[3]);
                    if (row < array.GetLength(0) && row >= 0 && array[row].Length > col && col >= 0)
                    {
                        double currValue = array[row][col];
                        array[row][col] = currValue - value;
                    }
                }


                command = Console.ReadLine();
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < array[row].Length; col++)
                {
                    Console.Write(array[row][col] + " ");
                }
                Console.WriteLine();
            }
                                  
        }
    }
}
