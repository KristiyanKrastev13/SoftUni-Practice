using System;
using System.Linq;

namespace miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] moves = Console.ReadLine().Split().ToArray();
            string[,] field = new string[size, size];
            int positionRow = -1;
            int positionCol = -1;
            int totalCoal = 0;
            int collectedCoal = 0;
            bool gameOver = false;
            bool allCoalCollected = false;

            for (int row = 0; row < size; row++)
            {
                string[] fieldinput = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < size; col++)
                {
                    field[row, col] = fieldinput[col];
                    if (fieldinput[col].ToString() == "c")
                    {
                        totalCoal++;
                    }
                    if (fieldinput[col].ToString() == "s")
                    {
                        positionCol = col;
                        positionRow = row;
                    }
                }
            }

            foreach (var move in moves)
            {
                if(move == "up")
                {
                    if (positionRow - 1 >= 0)
                    {
                        if (field[positionRow -1,positionCol] == "*")
                        {
                            field[positionRow - 1, positionCol] = "s";
                            field[positionRow , positionCol] = "*";
                            positionRow -= 1;
                            continue;
                        }
                        if (field[positionRow - 1, positionCol] == "e")
                        {
                            field[positionRow, positionCol] = "*";
                            positionRow -= 1;
                            gameOver = true;
                            break;
                        }
                        if (field[positionRow - 1, positionCol] == "c")
                        {
                            field[positionRow - 1, positionCol] = "s";
                            field[positionRow, positionCol] = "*";
                            positionRow -= 1;
                            collectedCoal++;  
                            
                        }
                    }
                }
                if (move == "down")
                {
                    if (positionRow + 1 < size )
                    {
                        if (field[positionRow + 1, positionCol] == "*")
                        {
                            field[positionRow + 1, positionCol] = "s";
                            field[positionRow, positionCol] = "*";
                            positionRow += 1;
                            continue;
                        }
                        if (field[positionRow + 1, positionCol] == "e")
                        {
                            field[positionRow, positionCol] = "*";
                            positionRow += 1;
                            gameOver = true;
                            break;
                        }
                        if (field[positionRow + 1, positionCol] == "c")
                        {
                            field[positionRow + 1, positionCol] = "s";
                            field[positionRow, positionCol] = "*";
                            positionRow += 1;
                            collectedCoal++;
                        }
                    }
                }
                if (move == "left")
                {
                    if (positionCol -1 >= 0)
                    {
                        if (field[positionRow , positionCol -1] == "*")
                        {
                            field[positionRow , positionCol -1] = "s";
                            field[positionRow, positionCol] = "*";
                            positionCol -= 1;
                            continue;
                        }
                        if (field[positionRow, positionCol - 1] == "e")
                        {
                            field[positionRow, positionCol] = "*";
                            positionCol -= 1;
                            gameOver = true;
                            break;
                        }
                        if (field[positionRow, positionCol -1] == "c")
                        {
                            field[positionRow , positionCol -1] = "s";
                            field[positionRow, positionCol] = "*";
                            positionCol -= 1;
                            collectedCoal++;
                        }
                    }
                }
                if (move == "right")
                {
                    if (positionCol + 1 < size)
                    {
                        if (field[positionRow, positionCol + 1] == "*")
                        {
                            field[positionRow, positionCol + 1] = "s";
                            field[positionRow, positionCol] = "*";
                            positionCol += 1;
                            continue;
                        }
                        if (field[positionRow, positionCol + 1] == "e")
                        {
                            field[positionRow, positionCol] = "*";
                            positionCol += 1;
                            gameOver = true;
                            break;
                        }
                        if (field[positionRow, positionCol + 1] == "c")
                        {
                            field[positionRow, positionCol + 1] = "s";
                            field[positionRow, positionCol] = "*";
                            positionCol += 1;
                            collectedCoal++;
                        }
                    }
                }
                if (collectedCoal == totalCoal)
                {
                    allCoalCollected = true;
                    break;

                }
            }
            if (gameOver)
            {
                Console.WriteLine($"Game over! ({positionRow}, {positionCol})");
            }
            if (allCoalCollected)
            {
                Console.WriteLine($"You collected all coals! ({positionRow}, {positionCol})");
            }
            if (!allCoalCollected && !gameOver)
           
            {
                Console.WriteLine($"{totalCoal - collectedCoal} coals left. ({positionRow}, {positionCol})");
            }
       
        }
    }
}
