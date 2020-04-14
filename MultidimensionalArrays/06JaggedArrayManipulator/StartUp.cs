using System;
using System.Linq;
namespace _06JaggedArrayManipulator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var JArray = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                JArray[row] = Console.ReadLine().Split().Select(double.Parse).ToArray();




            }
            Analyze(JArray);
            string command = Console.ReadLine();
            while (command!="End")
            {
                var commandInfo = command.Split();
          
                var row = int.Parse(commandInfo[1]);
                var col = int.Parse(commandInfo[2]);
                var funcion = int.Parse(commandInfo[3]);

                if (!isInside(JArray,row,col))
                {
                    command = Console.ReadLine();
                    continue;
                }
                else if (commandInfo[0] == "Add")
                {
                    JArray[row][col]+= funcion;
                }
                else
                {
                    JArray[row][col] -= funcion;
                }
                command = Console.ReadLine();
            }
            foreach (var row in JArray)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }

        static bool isInside(double[][] jArray, int row, int col )
        {
            return row >= 0 && row < jArray.Length &&
                col >= 0 && col < jArray[row].Length;
        }

        private static void Analyze(double[][] jArray)
        {

            for (int row = 0; row < jArray.Length - 1; row++)
            {
                if (jArray[row].Length == jArray[row + 1].Length)
                {
                    for (int col = 0; col < jArray[row].Length; col++)
                    {
                        jArray[row][col] *= 2;
                        jArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jArray[row].Length; col++)
                    {
                        jArray[row][col] /= 2;
                        
                    }
                    for (int col = 0; col < jArray[row+1].Length; col++)
                    {
                        jArray[row+1][col] /= 2;
                    }
                }
            }

        }
    }
}
