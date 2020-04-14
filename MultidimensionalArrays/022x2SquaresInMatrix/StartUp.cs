using System;
using System.Collections.Generic;
using System.Linq;

namespace _022x2SqueresInMatrix
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] matrix = ReadCharMatrix(rows,cols);
            int counter = 0;
            for (int row = 0; row <= rows-2; row++)
            {
                for (int col = 0; col <= cols-2; col++)
                {
                    if (matrix[row,col]==matrix[row,col+1]&&
                        matrix[row,col]==matrix[row+1,col]&&
                        matrix[row,col]==matrix[row+1,col+1])
                    {
                        counter++;
                    }



                }

            }
            Console.WriteLine(counter);











        }







        
















         private static int[,] ReadIntMatrix(int rows, int cols)
        {
            var matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var rowValues = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }


            }
            return matrix;
        }
        private static char[,] ReadCharMatrix(int rows, int cols)
        {
            var matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var rowValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }


            }
            return matrix;
        }
        private  static void PrintMatrix(char[,]matrix)
        {
          
            for (int row = 0; row < matrix.GetLength(0); row++)
            
                for (int col = 0; col <matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
            Console.WriteLine();
            }
        }
    }

