using System;

namespace ProblemTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[][] field = new char[rows][];
            int positionRow = 0;
            int positionCol = 0;
            bool won = false;

            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                char[] currRow = input.ToCharArray();
                field[row] = new char[currRow.Length];
                field[row] = currRow;
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    char currElement = field[row][col];
                    if (currElement == 'M')
                    {
                        positionRow = row;
                        positionCol = col;
                    }
                }
            }
            string[] actions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (lives != 0)
            {              
                string direction = actions[0];
                int enemyRow = int.Parse(actions[1]);
                int enemyCol = int.Parse(actions[2]);

                field[enemyRow][enemyCol] = 'B';
                if (direction == "W")
                {
                    lives -= 1;
                    if (positionRow - 1 >= 0)
                    {
                        if (field[positionRow - 1][positionCol] == '-')
                        {
                            if (lives > 0)
                            {
                                field[positionRow][positionCol] = '-';
                                field[positionRow - 1][positionCol] = 'M';
                                positionRow -= 1;
                                
                                actions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                                continue;
                            }
                            else
                            {
                                field[positionRow][positionCol] = '-';
                                field[positionRow - 1][positionCol] = 'X';
                                positionRow -= 1;
                                break;
                            }
                            

                        }
                        if (field[positionRow - 1][positionCol] == 'B')
                        {
                            if (lives - 2 > 0)
                            {
                                field[positionRow][positionCol] = '-';
                                field[positionRow - 1][positionCol] = 'M';
                                positionRow -= 1;
                                lives -= 2;
                               
                                actions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                                continue;
                            }
                            else
                            {
                                lives -= 2;
                                field[positionRow][positionCol] = '-';
                                field[positionRow - 1][positionCol] = 'X';
                                positionRow -= 1;
                                break;
                            }
                        }
                        if (field[positionRow - 1][positionCol] == 'P')
                        {
                            field[positionRow][positionCol] = '-';
                            field[positionRow - 1][positionCol] = '-';
                            won = true;
                            break;
                        }
                    }
                    else
                    {
                        if (lives <= 0)
                        {
                            field[positionRow][positionCol] = 'X';
                        }
                    }
                }
                if (direction == "S")
                {
                    lives -= 1;
                    if (positionRow + 1 < rows)
                    {
                        if (field[positionRow + 1][positionCol] == '-')
                        {
                            if(lives > 0)
                            {
                                field[positionRow][positionCol] = '-';
                                field[positionRow + 1][positionCol] = 'M';
                                positionRow += 1;
                                
                                actions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                                continue;
                            }
                            else
                            {
                                field[positionRow][positionCol] = '-';
                                field[positionRow + 1][positionCol] = 'X';
                                positionRow += 1;
                                break;
                            }
 
                            
                            
                        }
                        if (field[positionRow + 1][positionCol] == 'B')
                        {
                            if (lives - 2 > 0)
                            {
                                field[positionRow][positionCol] = '-';
                                field[positionRow + 1][positionCol] = 'M';
                                positionRow += 1;
                                lives -= 2;
                                
                                actions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                                continue;
                            }
                            else
                            {
                                lives -= 2;
                                field[positionRow][positionCol] = '-';
                                field[positionRow + 1][positionCol] = 'X';
                                positionRow += 1;
                                break;
                            }
                        }
                        if (field[positionRow + 1][positionCol] == 'P')
                        {
                            field[positionRow][positionCol] = '-';
                            field[positionRow + 1][positionCol] = '-';
                            won = true;
                            break;
                        }
                    }
                    else
                    {
                        if(lives <= 0)
                        {
                            field[positionRow][positionCol] = 'X';
                        }
                    }
                }
                if (direction == "A")
                {
                    lives -= 1;
                    if (positionCol - 1 >= 0)
                    {

                        if (field[positionRow][positionCol - 1] == '-')
                        {
                            if (lives > 0)
                            {
                                field[positionRow][positionCol] = '-';
                                field[positionRow][positionCol - 1] = 'M';
                                positionCol -= 1;
                                
                                actions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                                continue;
                            }
                            else
                            {
                                field[positionRow][positionCol] = '-';
                                field[positionRow][positionCol - 1] = 'X';
                                positionCol -= 1;
                                break;
                            }
                        }
                        if (field[positionRow][positionCol - 1] == 'B')
                        {
                            if (lives - 2 > 0)
                            {
                                field[positionRow][positionCol] = '-';
                                field[positionRow][positionCol - 1] = 'M';
                                positionCol -= 1;
                                lives -= 2;
                               
                                actions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                                continue;
                            }
                            else
                            {
                                lives -= 2;
                                field[positionRow][positionCol] = '-';
                                field[positionRow][positionCol - 1] = 'X';
                                positionCol -= 1;
                                break;
                            }
                        }
                        if (field[positionRow][positionCol - 1] == 'P')
                        {
                            field[positionRow][positionCol] = '-';
                            field[positionRow][positionCol - 1] = '-';
                            won = true;
                            break;
                        }
                    }
                    else
                    {
                        if (lives <= 0)
                        {
                            field[positionRow][positionCol] = 'X';
                        }
                    }
                }
                if (direction == "D")
                {
                    lives -= 1;
                    if (positionCol + 1 < field[positionRow].Length)
                    {
                        if (field[positionRow][positionCol + 1] == '-')
                        {
                            if (lives > 0)
                            {
                                field[positionRow][positionCol] = '-';
                                field[positionRow][positionCol + 1] = 'M';
                                positionCol += 1;
                                
                                actions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                                continue;
                            }
                            else
                            {
                                field[positionRow][positionCol] = '-';
                                field[positionRow][positionCol + 1] = 'X';
                                positionCol += 1;
                                break;
                               
                            }
                           
                        }
                        if (field[positionRow][positionCol + 1] == 'B')
                        {
                            if (lives - 2 > 0)
                            {
                                field[positionRow][positionCol] = '-';
                                field[positionRow][positionCol + 1] = 'M';
                                positionCol += 1;
                                lives -= 2;
                                
                                actions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                                continue;
                            }
                            else
                            {
                                lives -= 2;
                                field[positionRow][positionCol] = '-';
                                field[positionRow][positionCol + 1] = 'X';
                                positionCol += 1;
                                break;
                            }
                        }
                        if (field[positionRow][positionCol + 1] == 'P')
                        {
                            field[positionRow][positionCol] = '-';
                            field[positionRow][positionCol + 1] = '-';
                            won = true;
                            break;
                        }
                    }
                    else
                    {
                        if (lives <= 0)
                        {
                            field[positionRow][positionCol] = 'X';
                        }
                    }
                }
                PrintThis(field, rows);
                actions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            if (won)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
            }
            else
            {
                Console.WriteLine($"Mario died at {positionRow};{positionCol}.");
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    Console.Write($"{field[row][col]}");
                }
                Console.WriteLine();
            }
            static void PrintThis(char[][] array, int rows)
            {
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < array[row].Length; col++)
                    {
                        Console.Write($"{array[row][col]}");
                    }
                    Console.WriteLine();
                }
            }
        }

        
    }
}
