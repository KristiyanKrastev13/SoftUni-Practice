using System;

namespace ProblemTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int moves = int.Parse(Console.ReadLine());
            char[,] field = new char[size, size];
            int possitioRow = 0;
            int possitionCol = 0;
            bool won = false;

            for (int row = 0; row < size; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    if (currentRow[col] == 'f')
                    {
                        possitioRow = row;
                        possitionCol = col;
                    }
                    field[row, col] = currentRow[col];
                }
            }

            for (int i = 0; i < moves; i++)
            {
             
                string nextMove = Console.ReadLine();

                if (nextMove == "up")
                {
                    if (possitioRow - 1 >= 0)
                    {
                        char nextPoss = field[possitioRow - 1, possitionCol];
                        if (nextPoss == 'T')
                        {
                            continue;
                        }
                        if (nextPoss == 'B')
                        {
                            if (possitioRow - 2 >= 0)
                            {
                                field[possitioRow - 2, possitionCol] = 'f';
                                field[possitioRow, possitionCol] = '-';
                                possitioRow -= 2;
                                continue;
                            }
                            if (possitioRow - 2 < 0)
                            {
                                field[size - 1, possitionCol] = 'f';
                                field[possitioRow, possitionCol] = '-';
                                possitioRow--;
                            }
                        }
                        if (nextPoss == 'F')
                        {
                            won = true;
                            field[possitioRow - 1, possitionCol] = 'f';
                            field[possitioRow, possitionCol] = '-';
                            break;
                        }
                        if (nextPoss == '-')
                        {
                            field[possitioRow - 1, possitionCol] = 'f';
                            field[possitioRow, possitionCol] = '-';
                            possitioRow--;
                            continue;
                        }
                    }
                    if (possitioRow - 1 < 0)
                    {
                        field[size - 1, possitionCol] = 'f';
                        field[possitioRow, possitionCol] = '-';
                        possitioRow = size - 1;
                    }
                }
                if (nextMove == "down")
                {
                    if (possitioRow + 1 < size)
                    {
                        char nextPoss = field[possitioRow + 1, possitionCol];
                        if (nextPoss == 'T')
                        {
                            continue;
                        }
                        if (nextPoss == 'B')
                        {
                            if (possitioRow + 2 < size)
                            {
                                field[possitioRow + 2, possitionCol] = 'f';
                                field[possitioRow, possitionCol] = '-';
                                possitioRow += 2;
                                continue;
                            }
                            if (possitioRow + 2 >= size)
                            {
                                field[0, possitionCol] = 'f';
                                field[possitioRow, possitionCol] = '-';
                                possitioRow = 0;
                            }
                        }
                        if (nextPoss == 'F')
                        {
                            won = true;
                            field[possitioRow + 1, possitionCol] = 'f';
                            field[possitioRow, possitionCol] = '-';
                            break;
                        }
                        if (nextPoss == '-')
                        {
                            field[possitioRow + 1, possitionCol] = 'f';
                            field[possitioRow, possitionCol] = '-';
                            possitioRow++;
                            continue;
                        }
                    }
                    if (possitioRow + 1 >= size)
                    {
                        field[0, possitionCol] = 'f';
                        field[possitioRow, possitionCol] = '-';
                        possitioRow = 0;
                    }
                }
                if (nextMove == "right")
                {
                    if (possitionCol + 1 < size)
                    {
                        char nextPoss = field[possitioRow, possitionCol + 1];
                        if (nextPoss == 'T')
                        {
                            continue;
                        }
                        if (nextPoss == 'B')
                        {
                            if (possitionCol + 2 < size)
                            {
                                field[possitioRow, possitionCol + 2] = 'f';
                                field[possitioRow, possitionCol] = '-';
                                possitionCol += 2;
                                continue;
                            }
                            if (possitionCol + 2 >= size)
                            {
                                field[possitioRow, 0] = 'f';
                                field[possitioRow, possitionCol] = '-';
                                possitionCol = 0;
                            }
                        }
                        if (nextPoss == 'F')
                        {
                            field[possitioRow, possitionCol + 1] = 'f';
                            field[possitioRow, possitionCol] = '-';
                            won = true;
                            break;
                        }
                        if (nextPoss == '-')
                        {
                            field[possitioRow, possitionCol +1] = 'f';
                            field[possitioRow, possitionCol] = '-';
                            possitionCol++;
                            continue;
                        }
                    }
                    if (possitionCol + 1 >= size)
                    {
                        if (field[possitioRow, 0] == 'F')
                        {
                            field[possitioRow, 0] = 'f';
                            field[possitioRow, possitionCol] = '-';
                            won = true;
                            break;
                        }
                        field[possitioRow, 0] = 'f';
                        field[possitioRow, possitionCol] = '-';
                        possitionCol = 0;
                    }
                }
                if (nextMove == "left")
                {
                    if (possitionCol - 1 >= 0)
                    {
                        char nextPoss = field[possitioRow, possitionCol - 1];
                        if (nextPoss == 'T')
                        {
                            continue;
                        }
                        if (nextPoss == 'B')
                        {
                            if (possitionCol - 2 >= 0)
                            {
                                field[possitioRow, possitionCol - 2] = 'f';
                                field[possitioRow, possitionCol] = '-';
                                possitionCol -= 2;
                                continue;
                            }
                            if (possitionCol - 2 < 0)
                            {
                                field[possitioRow, size -1] = 'f';
                                field[possitioRow, possitionCol] = '-';
                                possitionCol = size - 1;
                            }
                        }
                        if (nextPoss == 'F')
                        {
                            won = true;
                            field[possitioRow, possitionCol - 1] = 'f';
                            field[possitioRow, possitionCol] = '-';
                            break;
                        }
                        if (nextPoss == '-')
                        {
                            field[possitioRow, possitionCol - 1] = 'f';
                            field[possitioRow, possitionCol] = '-';
                            possitionCol--;
                            continue;
                        }
                    }
                    if (possitionCol -1 < 0)
                    {
                        field[possitioRow, size - 1] = 'f';
                        field[possitioRow, possitionCol] = '-';
                        possitionCol = size - 1;
                    }
                }
            }

            if (won)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }
            for (int row = 0; row < size; row++)
            {

                for (int col = 0; col < size; col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
