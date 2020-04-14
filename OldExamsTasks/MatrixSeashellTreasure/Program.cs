using System;
using System.Collections.Generic;
using System.Linq;

namespace MatrixSeashellTreasure
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var collection = new List<char>();

            char[][] beach = new char[n][];

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine().Replace(" ", "").ToCharArray();



                beach[row] = input;

            }

            int stolen = 0;
            string command;
            while ((command = Console.ReadLine()) != "Sunset")
            {
                var commandInfo = command.Split().ToArray();
                var row = int.Parse(commandInfo[1]);
                var col = int.Parse(commandInfo[2]);

                if (commandInfo[0] == "Collect" && IsIndexValid(beach, row, col) && beach[row][col] != '-')
                {
                    collection.Add(beach[row][col]);
                    beach[row][col] = '-';

                }
                else if (commandInfo[0] == "Steal")
                {
                    var direction = commandInfo[3];
                    if (IsIndexValid(beach, row, col))
                    {
                        if (direction == "down")
                        {
                            for (int i = row; i <= row + 3; i++)
                            {
                                if (IsIndexValid(beach, i, col) && beach[i][col] != '-')
                                {
                                    stolen++;
                                    beach[i][col] = '-';

                                }
                            }

                        }
                        else if (direction == "up")
                        {
                            for (int i = row; i >= row - 3; i--)
                            {
                                if (IsIndexValid(beach, i, col) && beach[i][col] != '-')
                                {
                                    stolen++;
                                    beach[i][col] = '-';

                                }
                            }

                        }
                        else if (direction=="left")
                        {
                            for (int i = col; i >= col-3; i--)
                            {
                                if (IsIndexValid(beach,row,i) && beach[row][i] !='-')
                                {
                                    stolen++;
                                    beach[row][i] = '-';
                                }
                                
                            }


                        }
                        else if (direction=="right")
                        {
                            {
                                for (int i = col; i <= col+3; i++)
                                {
                                    if (IsIndexValid(beach,row,i)&& beach[row][i] !='-')
                                    {
                                        stolen++;
                                        beach[row][i] = '-';
                                    }
                                }
                            }
                        }
                    }
                }
            }

            foreach (var row in beach)
            {
                Console.WriteLine(string.Join(' ',row));
            }

            if (collection.Count>0)
            {
                Console.WriteLine($"Collected seashells: {collection.Count} -> {string.Join(", ", collection)}");
            }
            else
            {
                Console.WriteLine($"Collected seashells: {collection.Count}");
            }

            Console.WriteLine($"Stolen seashells: {stolen}");
        }
        public static bool IsIndexValid(char[][] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.Length &&
                   col >= 0 && col < matrix[row].Length
                ? true
                : false;
        }
    }
}
