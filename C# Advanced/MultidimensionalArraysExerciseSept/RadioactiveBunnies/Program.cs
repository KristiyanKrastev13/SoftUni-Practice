using System;
using System.Linq;

namespace RadioactiveBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            string[,] matrix = new string[rows, cols];
            int rowIndexOfPlayer = 0;
            int colIndexOfPlayer = 0;
            bool isDead = false;

            for (int row = 0; row < rows; row++)
            {
                string currLair = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    if (currLair[col].ToString() == "P")
                    {
                        rowIndexOfPlayer = row;
                        colIndexOfPlayer = col;
                    }
                    matrix[row, col] = currLair[col].ToString();
                }
            }
            string moves = Console.ReadLine();
            string[] move = new string[moves.Length];
            for (int i = 0; i < moves.Length; i++)
            {
                move[i] = moves[i].ToString();
            }

            for (int i = 0; i < move.Length; i++)
            {
                if(!isDead)
                {
                    if (move[i] == "L")
                    {
                        if (IsPositionValidLeft(matrix, rows, cols, rowIndexOfPlayer, colIndexOfPlayer))
                        {
                            if (matrix[rowIndexOfPlayer, colIndexOfPlayer - 1] == ".")
                            {
                                matrix[rowIndexOfPlayer, colIndexOfPlayer] = ".";
                                matrix[rowIndexOfPlayer, colIndexOfPlayer - 1] = "P";
                                colIndexOfPlayer = colIndexOfPlayer - 1;
                                continue;
                            }
                            if (matrix[rowIndexOfPlayer, colIndexOfPlayer - 1] == "B")
                            {
                                isDead = true;
                            }
                        }
                    }
                    if (move[i] == "R")
                    {
                        if (IsPositionValidRight(matrix, rows, cols, rowIndexOfPlayer, colIndexOfPlayer))
                        {
                            if (matrix[rowIndexOfPlayer, colIndexOfPlayer + 1] == ".")
                            {
                                matrix[rowIndexOfPlayer, colIndexOfPlayer] = ".";
                                matrix[rowIndexOfPlayer, colIndexOfPlayer + 1] = "P";
                                colIndexOfPlayer = colIndexOfPlayer + 1;
                                continue;
                            }
                            if (matrix[rowIndexOfPlayer, colIndexOfPlayer + 1] == "B")
                            {
                                isDead = true;
                            }
                        }
                    }
                    if (move[i] == "U")
                    {
                        if (IsPositionValidUp(matrix, rows, cols, rowIndexOfPlayer, colIndexOfPlayer))
                        {
                            if (matrix[rowIndexOfPlayer - 1, colIndexOfPlayer] == ".")
                            {
                                matrix[rowIndexOfPlayer, colIndexOfPlayer] = ".";
                                matrix[rowIndexOfPlayer - 1, colIndexOfPlayer] = "P";
                                rowIndexOfPlayer -= 1;
                                continue;
                            }
                            if (matrix[rowIndexOfPlayer - 1, colIndexOfPlayer] == "B")
                            {
                                isDead = true;
                            }
                        }
                    }
                    if (move[i] == "D")
                    {
                        if (IsPositionValidUp(matrix, rows, cols, rowIndexOfPlayer, colIndexOfPlayer))
                        {
                            if (matrix[rowIndexOfPlayer + 1, colIndexOfPlayer] == ".")
                            {
                                matrix[rowIndexOfPlayer, colIndexOfPlayer] = ".";
                                matrix[rowIndexOfPlayer + 1, colIndexOfPlayer] = "P";
                                rowIndexOfPlayer += 1;
                                continue;
                            }
                            if (matrix[rowIndexOfPlayer + 1, colIndexOfPlayer] == "B")
                            {
                                isDead = true;
                            }
                        }
                    }
                }
               

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        string currSpace = matrix[row, col];
                        if (currSpace == "B")
                        {
                            if (IsPositionValidRight(matrix, rows, cols, row, col))
                            {
                                if (matrix[row, col+1] == ".")
                                {
                                    matrix[row, col + 1] = "B";
                                }                              
                            }
                            if (IsPositionValidLeft(matrix, rows, cols, row, col))
                            {
                                if (matrix[row, col - 1] == ".")
                                {
                                    matrix[row, col - 1] = "B";
                                }
                            }
                            if (IsPositionValidUp(matrix, rows, cols, row, col))
                            {
                                if (matrix[row -1 , col] == ".")
                                {
                                    matrix[row- 1, col] = "B";
                                }
                            }
                            if (IsPositionValidDown(matrix, rows, cols, row, col))
                            {
                                if (matrix[row + 1, col] == ".")
                                {
                                    matrix[row + 1, col] = "B";
                                }
                            }
                        }
                    }
                }
                if (isDead)
                {
                    break;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }

;
        }

        public static bool  IsPositionValidRight(string[,] matrix, int rows, int cols, int row, int col)
        {
            if (col + 1 < cols -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPositionValidLeft(string[,] matrix, int rows, int cols, int row, int col)
        {
            if (col - 1 >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsPositionValidDown(string[,] matrix, int rows, int cols, int row, int col)
        {
            if (row + 1 <= rows - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsPositionValidUp(string[,] matrix, int rows, int cols, int row, int col)
        {
            if (row - 1 >= 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
