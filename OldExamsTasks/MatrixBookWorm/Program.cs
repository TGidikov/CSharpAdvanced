using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MatrixBookWorm
{
    class Program
    {
        static void Main(string[] args)
        {

            var initialWord = Console.ReadLine()
                .ToCharArray();
            Stack<char> word = new Stack<char>(initialWord);

            int n = int.Parse(Console.ReadLine());

            char[][] field = new char[n][];
            int playerRow = -1;
            int playerCol = -1;
            bool playerPosFound = false;



            for (int row = 0; row < n; row++)
            {
                var currentRow = Console.ReadLine().ToCharArray();

                if (!playerPosFound)
                {
                    for (int col = 0; col < currentRow.Length; col++)
                    {
                        if (currentRow[col] == 'P')
                        {
                            playerRow = row;
                            playerCol = col;
                            playerPosFound = true;
                            break;
                        }
                    }
                }

                field[row] = currentRow;
            }


            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "up")
                {
                    if (playerRow - 1 >= 0) //n
                    {
                        playerRow--;
                        char symbol = field[playerRow][playerCol];
                        if (char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }

                        field[playerRow][playerCol] = 'P';
                        field[playerRow + 1][playerCol] = '-';
                    }
                    else
                    {
                        if (word.Count > 0)
                        {
                            word.Pop();
                        }
                    }
                }
                else if (command == "down")
                {
                    if (playerRow + 1 < n)
                    {
                        playerRow++;
                        char symbol = field[playerRow][playerCol];
                        if (char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }

                        field[playerRow][playerCol] = 'P';
                        field[playerRow - 1][playerCol] = '-';
                    }
                    else
                    {
                        if (word.Count > 0)
                        {
                            word.Pop();
                        }
                    }

                }
                else if (command == "left")
                {
                    if (playerCol - 1 >= 0)
                    {
                        playerCol--;
                        char symbol = field[playerRow][playerCol];
                        if (char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }

                        field[playerRow][playerCol] = 'P';
                        field[playerRow][playerCol + 1] = '-';

                    }
                    else
                    {
                        if (word.Count > 0)
                        {
                            word.Pop();
                        }

                    }
                }
                else if (command == "right")
                {
                    if (playerCol + 1 < n)
                    {
                        playerCol++;
                        char symbol = field[playerRow][playerCol];
                        if (char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }

                        field[playerRow][playerCol] = 'P';
                        field[playerRow][playerCol - 1] = '-';

                    }
                    else
                    {
                        if (word.Count > 0)
                        {
                            word.Pop();
                        }
                    }


                }
            }

            Console.WriteLine(string.Join("", word.Reverse()));

                for (int row = 0; row < field.Length; row++)
                {
                    for (int col = 0; col < field[row].Length; col++)
                    {
                        Console.Write(field[row][col]);
                    }

                    Console.WriteLine();
                }


            



        }
    }
}