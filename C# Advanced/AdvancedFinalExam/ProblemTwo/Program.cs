using System;

namespace ProblemTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] field = new char[8, 8];
            int whiteRow = -1;
            int whiteCol = -1;
            int blackRow = -1;
            int blackCol = -1;
            string[,] matrix = new string[8,8];

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (col == 0)                   
                        matrix[row, col] = "a";
                    if (col == 1)
                        matrix[row, col] = "b";
                    if (col == 2)
                        matrix[row, col] = "c";
                    if (col == 3)
                        matrix[row, col] = "d";
                    if (col == 4)
                        matrix[row, col] = "e";
                    if (col == 5)
                        matrix[row, col] = "f";
                    if (col == 6)
                        matrix[row, col] = "g";
                    if (col == 7)
                        matrix[row, col] = "h";

                }
            }
            for (int col = 0; col < 8; col++)
            {
                for (int row = 0; row < 8; row++)
                {

                    if (row == 0)
                        matrix[row, col] += "8";
                    if (row == 1)
                        matrix[row, col] += "7";
                    if (row == 2)
                        matrix[row, col] += "6";
                    if (row == 3)
                        matrix[row, col] += "5";
                    if (row == 4)
                        matrix[row, col] += "4";
                    if (row == 5)
                        matrix[row, col] += "3";
                    if (row == 6)
                        matrix[row, col] += "2";
                    if (row == 7)
                        matrix[row, col] += "1";
                }
            }


            for (int row  = 0; row < 8; row++)
            {
                string currLine = Console.ReadLine();
                for (int col = 0; col < 8; col++)
                {
                    field[row, col] = currLine[col];
                    if (field[row,col] == 'w')
                    {
                        whiteRow = row;
                        whiteCol = col;

                    }
                    if (field[row, col] == 'b')
                    {
                        blackRow = row;
                        blackCol = col;
                    }
                }
            }
            int moves = 1;
            while (true)
            {
               
                if (moves % 2 != 0)
                {
                    field[whiteRow, whiteCol] = '-';
                    if (whiteRow - 1  >= 0)
                    {


                        if (whiteCol - 1 >= 0)
                        {
                            if (field[whiteRow - 1, whiteCol - 1] == 'b')
                            {
                                
                                
                                Console.WriteLine($"Game over! White capture on {matrix[whiteRow -1,whiteCol -1]}.");
                                whiteRow--;
                                break;
                            }
                        }
                        if (whiteCol + 1 < 8)
                        {
                            if (field[whiteRow - 1, whiteCol + 1] == 'b')
                            {
                                
                                Console.WriteLine($"Game over! White capture on {matrix[whiteRow - 1, whiteCol + 1]}.");
                                whiteRow--;
                                break;
                            }
                        }
                        whiteRow--;
                        if (whiteRow == 0)
                        {
                            Console.WriteLine($"Game over! White pawn is promoted to a queen at {matrix[whiteRow, whiteCol]}.");
                            break;
                        }
                        else
                        {
                            
                            field[whiteRow, whiteCol] = 'w';
                        }
                    }
                }
                if (moves % 2 == 0)
                {
                    field[blackRow, blackCol] = '-';
                    if (blackRow + 1 < 8)
                    {
                        
                        
                        if (blackCol - 1 >= 0)
                        {
                            if (field[blackRow + 1, blackCol - 1] == 'w')
                            {
                                
                                Console.WriteLine($"Game over! Black capture on {matrix[blackRow + 1, blackCol - 1]}.");
                                blackRow++;
                                break;
                            }
                        }
                        if (blackCol + 1 < 8)
                        {
                            if (field[blackRow + 1, blackCol + 1] == 'w')
                            {
                                
                                Console.WriteLine($"Game over! Black capture on {matrix[blackRow + 1, blackCol + 1]}.");
                                blackRow++;
                                break;
                            }
                        }
                        blackRow++;
                        if (blackRow == 7)
                        {
                            Console.WriteLine($"Game over! Black pawn is promoted to a queen at {matrix[whiteRow, whiteCol]}.");
                            break;
                        }
                        else
                        {
                            
                            field[blackRow, blackCol] = 'b';
                        }
                    }
                }
                moves++;
                

            }
    
        }
    }
}
