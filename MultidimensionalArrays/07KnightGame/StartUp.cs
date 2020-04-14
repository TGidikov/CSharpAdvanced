using System;
using System.Collections.Generic;
namespace _07KnightGame
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] chessBoard = new char[size, size];
            int maxAttacks = 0;
            var knightsCount = 0;
            var killerRow = 0;
            var killerCol = 0;
            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    chessBoard[row, col] = input[col];
                }

            }
            while (true)
            {
                maxAttacks = 0;
                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {
                   
                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        int currentKnightsAttack = 0;

                        if (chessBoard[row, col] == 'K')
                        {
                            if (isInside(chessBoard, row - 2, col + 1) && (chessBoard[row - 2, col + 1] == 'K'))
                            {

                                currentKnightsAttack++;
                            }
                            if (isInside(chessBoard, row - 2, col - 1) && (chessBoard[row - 2, col - 1] == 'K'))
                            {
                                currentKnightsAttack++;
                            }
                            if (isInside(chessBoard, row - 1, col + 2) && (chessBoard[row - 1, col + 2] == 'K'))
                            {
                                currentKnightsAttack++;
                            }
                            if (isInside(chessBoard, row - 1, col - 2) && (chessBoard[row - 1, col - 2] == 'K'))
                            {
                                currentKnightsAttack++;
                            }
                            if (isInside(chessBoard, row + 1, col + 2) && (chessBoard[row + 1, col + 2] == 'K'))
                            {
                                currentKnightsAttack++;
                            }
                            if (isInside(chessBoard, row + 1, col - 2) && (chessBoard[row + 1, col - 2] == 'K'))
                            {
                                currentKnightsAttack++;
                            }
                            if (isInside(chessBoard, row + 2, col + 1) && (chessBoard[row + 2, col + 1] == 'K'))
                            {
                                currentKnightsAttack++;
                            }
                            if (isInside(chessBoard, row + 2, col - 1) && (chessBoard[row + 2, col - 1] == 'K'))
                            {
                                currentKnightsAttack++;
                            }


                        }
                        if (currentKnightsAttack > maxAttacks)
                        {
                            maxAttacks = currentKnightsAttack;
                            killerRow = row;
                            killerCol = col;
                        }

                    }
                }
                if (maxAttacks > 0)
                {
                    chessBoard[killerRow, killerCol] = '0';
                    knightsCount++;
                }
                else
                {
                    Console.WriteLine(knightsCount);
                    break;
                }
            }
        }

        private static bool isInside(char[,] chessBoard, int row, int col)
        {
            return row >= 0 && row < chessBoard.GetLength(0) &&
              col >= 0 && col < chessBoard.GetLength(1);
        }
    }
}
