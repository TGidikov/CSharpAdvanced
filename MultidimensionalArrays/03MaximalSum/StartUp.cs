using System;
using System.Collections.Generic;
using System.Linq;
namespace _03MaximalSum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = elements[0];
            int cols = elements[1];
            var matrix = ReadIntMatrix(rows, cols);
            var maxNumber = int.MinValue;
            int targetRow = 0;
            int targetcol = 0;
            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                for (int col = 0; col< matrix.GetLength(1)-2; col++)
                {
                    int currentsum 

                         = matrix[row, col] + matrix[row, col+1]  + matrix[row, col + 2]+
                  matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]+
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentsum>maxNumber)
                    {
                        maxNumber = currentsum;
                        targetRow
                            = row;
                        targetcol = col;
                    }


                }
            }
            Console.WriteLine($"Sum = {maxNumber}");
            for (int row = targetRow; row <= targetRow+2; row++)
            {
                for (int col = targetcol; col <=targetcol+2; col++)
                {
                    Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            static  int[,] ReadIntMatrix(int rows, int cols)
            {
                var matrix = new int[rows, cols];
                for (int row = 0; row < rows; row++)
                {
                    var rowValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = rowValues[col];
                    }


                }
                return matrix;
            }


        }
    }
}
 