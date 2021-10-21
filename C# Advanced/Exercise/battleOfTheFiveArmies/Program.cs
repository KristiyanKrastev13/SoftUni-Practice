using System;

namespace battleOfTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[][] matrix = new char[rows][];
            int armyRow = -1;
            int armyCol = -1;
            bool win = false;

            for (int row = 0; row < rows; row++)
            {
                string currCol = Console.ReadLine();
                matrix[row] = new char[currCol.Length];
                for (int col = 0; col < matrix[row].Length; col++)
                {    
                    matrix[row][col] = currCol[col];
                    if (matrix[row][col] == 'A')
                    {
                        armyRow = row;
                        armyCol = col;
                    }
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                string direction = command[0];
                int enemyRow = int.Parse(command[1]);
                int enemyCol = int.Parse(command[2]);
                matrix[enemyRow][enemyCol] = 'O';
                energy--;
                if (direction == "up")
                {
                    matrix[armyRow][armyCol] = '-';
                    if (ValidLocation(matrix, armyRow - 1, armyCol))
                    {                       
                        armyRow -= 1;
                        if (matrix[armyRow][armyCol] == 'O')
                        {
                            energy -= 2;
                        }
                        else if (matrix[armyRow][armyCol] == 'M')
                        {
                            matrix[armyRow][armyCol] = '-';
                            win = true;
                            break;
                        }
                    }
                    if (energy <= 0 && win == false)
                    {
                        matrix[armyRow][armyCol] = 'X';
                        break;
                    }
                    else if (energy > 0 && win == false)
                    {
                        matrix[armyRow][armyCol] = 'A';
                    }
                }
                if (direction == "down")
                {
                    matrix[armyRow][armyCol] = '-';
                    if (ValidLocation(matrix, armyRow + 1, armyCol))
                    {
                        armyRow += 1;
                        if (matrix[armyRow][armyCol] == 'O')
                        {
                            energy -= 2;
                        }
                        else if (matrix[armyRow][armyCol] == 'M')
                        {
                            matrix[armyRow][armyCol] = '-';
                            win = true;
                            break;
                        }
                    }
                    if (energy <= 0 && win == false)
                    {
                        matrix[armyRow][armyCol] = 'X';
                        break;
                    }
                    else if (energy > 0 && win == false)
                    {
                        matrix[armyRow][armyCol] = 'A';
                    }
                }
                if (direction == "left")
                {
                    matrix[armyRow][armyCol] = '-';
                    if (ValidLocation(matrix, armyRow, armyCol - 1))
                    {
                        armyCol -= 1;
                        if (matrix[armyRow][armyCol] == 'O')
                        {
                            energy -= 2;
                        }
                        else if (matrix[armyRow][armyCol] == 'M')
                        {
                            matrix[armyRow][armyCol] = '-';
                            win = true;
                            break;
                        }
                    }
                    if (energy <= 0 && win == false)
                    {
                        matrix[armyRow][armyCol] = 'X';
                        break;
                    }
                    else if (energy > 0 && win == false)
                    {
                        matrix[armyRow][armyCol] = 'A';
                    }
                }
                if (direction == "right")
                {
                    matrix[armyRow][armyCol] = '-';
                    if (ValidLocation(matrix, armyRow, armyCol + 1))
                    {
                        armyCol += 1;
                        if (matrix[armyRow][armyCol] == 'O')
                        {
                            energy -= 2;
                        }
                        else if (matrix[armyRow][armyCol] == 'M')
                        {
                            matrix[armyRow][armyCol] = '-';
                            win = true;
                            break;
                        }
                    }
                    if (energy <= 0 && win == false)
                    {
                        matrix[armyRow][armyCol] = 'X';
                        break;
                    }
                    else if (energy > 0 && win == false)
                    {
                        matrix[armyRow][armyCol] = 'A';
                    }
                    if (win)
                    {
                        break;
                    }
                }
                
            }
            if (win)
            {
                Console.WriteLine($"The army managed to free the Middle World! Armor left: {energy}");
            }
            else
            {
                Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
            }
            Print(matrix);

        }
        public static void Print(char[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
              
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
        }

        public static bool ValidLocation(char[][] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length;
        }
    }
}
