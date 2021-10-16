using System;
using System.Linq;

namespace ProblemTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            char[][] field = new char[rows][];
            int tokensCollected = 0;
            int opponentCollected = 0;

            for (int row = 0; row < rows; row++)
            {
                string[] curr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string currReworked = String.Join("", curr);
                char[] currRow = currReworked.ToCharArray();
                field[row] = currRow;
            }
            string command = Console.ReadLine();
            while (command!= "Gong")
            {
                string[] actions = command.Split().ToArray();
                string action = actions[0];
                if (action == "Find")
                {
                    int row = int.Parse(actions[1]);
                    int col = int.Parse(actions[2]);
                    if (row >= 0 && row < rows && col >= 0 && col < field[row].Length)
                    {
                        char currentPosition = field[row][col];
                        if (currentPosition == 'T')
                        {
                            tokensCollected++;
                            field[row][col] = '-';
                        }                       
                    }
                }
                if (action == "Opponent")
                {
                    int row = int.Parse(actions[1]);
                    int col = int.Parse(actions[2]);
                    string directionToMove = actions[3];
                    if (row >= 0 && row < rows && col >= 0 && col < field[row].Length)
                    {
                        char currentPosition = field[row][col];
                        if (currentPosition == 'T')
                        {
                            opponentCollected++;
                            field[row][col] = '-';
                        }
                        if (directionToMove == "up")
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                if (row - 1 >= 0)
                                {
                                    row--;
                                    if (field[row][col] == 'T')
                                    {
                                        opponentCollected++;
                                        field[row][col] = '-';
                                    }
                                }
                            }
                        }
                        if (directionToMove == "down")
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                if (row + 1 < rows)
                                {
                                    row++;
                                    if (field[row][col] == 'T')
                                    {
                                        opponentCollected++;
                                        field[row][col] = '-';
                                    }
                                }
                            }
                        }
                        if (directionToMove == "left")
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                if (col - 1 >= 0)
                                {
                                    col--;
                                    if (field[row][col] == 'T')
                                    {
                                        opponentCollected++;
                                        field[row][col] = '-';
                                    }
                                }
                            }
                        }
                        if (directionToMove == "right")
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                if (col + 1 < field[row].Length)
                                {
                                    col++;
                                    if (field[row][col] == 'T')
                                    {
                                        opponentCollected++;
                                        field[row][col] = '-';
                                    }
                                }
                            }
                        }
                    }

                }
                command = Console.ReadLine();

            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(String.Join(" ", field[i]));
            }
            Console.WriteLine($"Collected tokens: {tokensCollected}");
            Console.WriteLine($"Opponent's tokens: {opponentCollected}");

            
        }
    }
}
