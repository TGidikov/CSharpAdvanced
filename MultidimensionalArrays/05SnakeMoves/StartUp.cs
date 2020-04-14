using System;
using System.Collections.Generic;
using System.Linq;
namespace _05SnakeMoves
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] dimmensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string snakeName = Console.ReadLine();

            int rows = dimmensions[0];
            int cols = dimmensions[1];
            int counter = 0;
            var matrix = new char[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snakeName[counter++];
                        if (counter == snakeName.Length)
                        {
                            counter = 0;
                        }
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snakeName[counter++];
                        if (counter == snakeName.Length)
                        {
                            counter = 0;
                        }

                    }
                }
            }



            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
