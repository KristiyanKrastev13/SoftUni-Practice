using System;
using System.Linq;

namespace ProblemTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] field = new char[size, size];
            string[] moves = Console.ReadLine().Split(',',StringSplitOptions.RemoveEmptyEntries).ToArray();
            int firstPlayerShips = 0;
            int secondPlayerShips = 0;
            int totalsunked = 0;
            int nextTurn = 1;
            int moveIndex = 0;
            for (int row = 0; row < size; row++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trimmed = string.Join("", input);

                char[] currCol = trimmed.ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    field[row, col] = currCol[col];

                    if (currCol[col] == '<')
                    {
                        firstPlayerShips++;
                    }
                    if (currCol[col] == '>')
                    {
                        secondPlayerShips++;
                    }
                }
            }
            while (moveIndex < moves.Length)
            {
                if (nextTurn % 2 != 0)
                {
                    string[] nextMove = moves[moveIndex].Split();
                    moveIndex++;
                    nextTurn++;
                    int row = int.Parse(nextMove[0]);
                    int col = int.Parse(nextMove[1]);
                    if (row < 0 || col < 0)
                    {
                        continue;
                    }
                    if (field[row, col] == '>')
                    {
                        field[row, col] = 'X';
                        secondPlayerShips--;
                        totalsunked++;
                    }
                    if (field[row, col] == '#')
                    {
                        field[row, col] = 'X';
                        if (row + 1 < size)
                        {
                            if (field[row + 1, col] == '>')
                            {
                                secondPlayerShips--;
                                totalsunked++;
                                field[row + 1, col] = 'X';
                            }
                            else if (field[row + 1, col] == '<')
                            {
                                firstPlayerShips--;
                                totalsunked++;
                                field[row + 1, col] = 'X';
                            }
                        }
                        if (row + 1 < size && col + 1 < size)
                        {
                            if (field[row + 1, col + 1] == '>')
                            {
                                secondPlayerShips--;
                                totalsunked++;
                                field[row + 1, col + 1] = 'X';
                            }
                            else if (field[row + 1, col + 1] == '<')
                            {
                                firstPlayerShips--;
                                totalsunked++;
                                field[row + 1, col + 1] = 'X';
                            }
                        }
                        if (col + 1 < size)
                        {
                            if (field[row, col + 1] == '>')
                            {
                                secondPlayerShips--;
                                totalsunked++;
                                field[row, col + 1] = 'X';
                            }
                            else if (field[row, col + 1] == '<')
                            {
                                firstPlayerShips--;
                                totalsunked++;
                                field[row, col + 1] = 'X';
                            }
                        }
                        if (row + 1 < size && col - 1 >= 0)
                        {
                            if (field[row + 1, col - 1] == '>')
                            {
                                secondPlayerShips--;
                                totalsunked++;
                                field[row + 1, col - 1] = 'X';
                            }
                            else if (field[row + 1, col - 1] == '<')
                            {
                                firstPlayerShips--;
                                totalsunked++;
                                field[row + 1, col - 1] = 'X';
                            }
                        }
                        if (row - 1 >= 0)
                        {
                            if (field[row - 1, col] == '>')
                            {
                                secondPlayerShips--;
                                totalsunked++;
                                field[row - 1, col] = 'X';
                            }
                            else if (field[row - 1, col] == '<')
                            {
                                firstPlayerShips--;
                                totalsunked++;
                                field[row - 1, col] = 'X';
                            }
                        }
                        if (row - 1 >= 0 && col - 1 >= 0)
                        {
                            if (field[row - 1, col - 1] == '>')
                            {
                                secondPlayerShips--;
                                totalsunked++;
                                field[row - 1, col - 1] = 'X';
                            }
                            else if (field[row - 1, col - 1] == '<')
                            {
                                firstPlayerShips--;
                                totalsunked++;
                                field[row - 1, col - 1] = 'X';
                            }
                        }
                        if (col - 1 >= 0)
                        {
                            if (field[row, col - 1] == '>')
                            {
                                secondPlayerShips--;
                                totalsunked++;
                                field[row, col - 1] = 'X';
                            }
                            else if (field[row, col - 1] == '<')
                            {
                                firstPlayerShips--;
                                totalsunked++;
                                field[row, col - 1] = 'X';
                            }
                        }
                        if (row + 1 < size && col + 1 < size)
                        {
                            if (field[row + 1, col + 1] == '>')
                            {
                                secondPlayerShips--;
                                totalsunked++;
                                field[row + 1, col + 1] = 'X';
                            }
                            else if (field[row + 1, col + 1] == '<')
                            {
                                firstPlayerShips--;
                                totalsunked++;
                                field[row + 1, col + 1] = 'X';
                            }
                        }
                        if (row - 1 >= 0 && col + 1 < size)
                        {
                            if (field[row - 1, col + 1] == '>')
                            {
                                secondPlayerShips--;
                                totalsunked++;
                                field[row - 1, col + 1] = 'X';
                            }
                            else if (field[row - 1, col + 1] == '<')
                            {
                                firstPlayerShips--;
                                totalsunked++;
                                field[row - 1, col + 1] = 'X';
                            }
                        }
                    }
                }
                else
                {
                    string[] nextMove = moves[moveIndex].Split();
                    moveIndex++;
                    nextTurn++;
                    int row = int.Parse(nextMove[0]);
                    int col = int.Parse(nextMove[1]);
                    if (row < 0 || col < 0)
                    {
                        continue;
                    }
                    if (field[row, col] == '<')
                    {
                        field[row, col] = 'X';
                        firstPlayerShips--;
                        totalsunked++;
                    }
                    if (field[row, col] == '#')
                    {
                        field[row, col] = 'X';
                        if (row + 1 < size)
                        {
                            if (field[row + 1, col] == '>')
                            {
                                secondPlayerShips--;
                                totalsunked++;
                                field[row + 1, col] = 'X';
                            }
                            else if (field[row + 1, col] == '<')
                            {
                                firstPlayerShips--;
                                totalsunked++;
                                field[row + 1, col] = 'X';
                            }
                        }
                        if (row + 1 < size && col + 1 < size)
                        {
                            if (field[row + 1, col + 1] == '>')
                            {
                                secondPlayerShips--;
                                totalsunked++;
                                field[row + 1, col + 1] = 'X';
                            }
                            else if (field[row + 1, col + 1] == '<')
                            {
                                firstPlayerShips--;
                                totalsunked++;
                                field[row + 1, col + 1] = 'X';
                            }
                        }
                        if (col + 1 < size)
                        {
                            if (field[row, col + 1] == '>')
                            {
                                secondPlayerShips--;
                                totalsunked++;
                                field[row, col + 1] = 'X';
                            }
                            else if (field[row, col + 1] == '<')
                            {
                                firstPlayerShips--;
                                totalsunked++;
                                field[row, col + 1] = 'X';
                            }
                        }
                        if (row + 1 < size && col - 1 >= 0)
                        {
                            if (field[row + 1, col - 1] == '>')
                            {
                                secondPlayerShips--;
                                totalsunked++;
                                field[row + 1, col - 1] = 'X';
                            }
                            else if (field[row + 1, col - 1] == '<')
                            {
                                firstPlayerShips--;
                                totalsunked++;
                                field[row + 1, col - 1] = 'X';
                            }
                        }
                        if (row - 1 >= 0)
                        {
                            if (field[row - 1, col] == '>')
                            {
                                secondPlayerShips--;
                                totalsunked++;
                                field[row - 1, col] = 'X';
                            }
                            else if (field[row - 1, col] == '<')
                            {
                                firstPlayerShips--;
                                totalsunked++;
                                field[row - 1, col] = 'X';
                            }
                        }
                        if (row - 1 >= 0 && col - 1 >= 0)
                        {
                            if (field[row - 1, col - 1] == '>')
                            {
                                secondPlayerShips--;
                                totalsunked++;
                                field[row - 1, col - 1] = 'X';
                            }
                            else if (field[row - 1, col - 1] == '<')
                            {
                                firstPlayerShips--;
                                totalsunked++;
                                field[row - 1, col - 1] = 'X';
                            }
                        }
                        if (col - 1 >= 0)
                        {
                            if (field[row, col - 1] == '>')
                            {
                                secondPlayerShips--;
                                totalsunked++;
                                field[row, col - 1] = 'X';
                            }
                            else if (field[row, col - 1] == '<')
                            {
                                firstPlayerShips--;
                                totalsunked++;
                                field[row, col - 1] = 'X';
                            }
                        }
                        if (row + 1 < size && col + 1 < size)
                        {
                            if (field[row + 1, col + 1] == '>')
                            {
                                secondPlayerShips--;
                                totalsunked++;
                                field[row + 1, col + 1] = 'X';
                            }
                            else if (field[row + 1, col + 1] == '<')
                            {
                                firstPlayerShips--;
                                totalsunked++;
                                field[row + 1, col + 1] = 'X';
                            }
                        }
                        if (row - 1 >= 0 && col + 1 < size)
                        {
                            if (field[row - 1, col + 1] == '>')
                            {
                                secondPlayerShips--;
                                totalsunked++;
                                field[row - 1, col + 1] = 'X';
                            }
                            else if (field[row - 1, col + 1] == '<')
                            {
                                firstPlayerShips--;
                                totalsunked++;
                                field[row - 1, col + 1] = 'X';
                            }
                        }
                    }
                }
                if (firstPlayerShips == 0 || secondPlayerShips == 0)
                {
                    break;
                }
             
            }
            if (firstPlayerShips == 0 || secondPlayerShips == 0)
            {
                if (firstPlayerShips == 0)
                {
                    Console.WriteLine($"Player Two has won the game! {totalsunked} ships have been sunk in the battle.");
                }
                else if (secondPlayerShips == 0)
                {
                    Console.WriteLine($"Player One has won the game! {totalsunked} ships have been sunk in the battle.");
                }
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {firstPlayerShips} ships left. Player Two has {secondPlayerShips} ships left.");
            }
        }
    }
}
