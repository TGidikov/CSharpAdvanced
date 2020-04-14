using System;

namespace MatrixSpaceStationEstablishment
{
    public class Program
    {
        private const int MIN_STAR_POWER_NEEDED = 50;
        private static char[][] field;
        private static int playerRow;
        private static int playerCol;
        private static int collectedPower;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            //FIllMethod
            FillMatrix(n);
            //EndFillMethod
            while (collectedPower < MIN_STAR_POWER_NEEDED)
            {
                string direction = Console.ReadLine();
                int nextRow = playerRow;
                int nextCol = playerCol;

                DetermineNextCoordinatesByDirection(direction, ref nextRow, ref nextCol);
                bool isOutside = CheckIdPlayerIsOutsideOfTheField(n, nextRow, nextCol);

                if (isOutside)
                {
                    field[playerRow][playerCol] = '-';
                    break;
                }

                ProceedMove(n, nextRow, nextCol);


            }

            PrintAll(n);
        }

        private static void PrintAll(int n)
        {
            if (collectedPower >= MIN_STAR_POWER_NEEDED)
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");


            }
            else
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }
            Console.WriteLine($"Star power collected: {collectedPower}");

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(String.Join("", field[row]));
            }
        }

        private static bool CheckIdPlayerIsOutsideOfTheField(int n, int nextRow, int nextCol)
        {
            return nextRow < 0 || nextRow >= n || nextCol < 0 || nextCol >= n;
        }

        private static void FillMatrix(int n)
        {
            field = new char[n][];
            bool found = false;
            for (int row = 0; row < n; row++)
            {
                var currRow = Console.ReadLine().ToCharArray();


                if (!found)
                {
                    for (int col = 0; col < currRow.Length; col++)
                    {
                        if (currRow[col] == 'S')
                        {
                            playerRow = row;
                            playerCol = col;
                            found = true;
                            break;
                        }

                    }
                }
                field[row] = currRow;

            }
        }

        private static void DetermineNextCoordinatesByDirection(string direction, ref int nextRow, ref int nextCol)
        {
            if (direction == "up")
            {
                nextRow = playerRow - 1;
                nextCol = playerCol;
            }
            else if (direction == "down")
            {
                nextRow = playerRow + 1;
                nextCol = playerCol;
            }
            else if (direction == "left")
            {
                nextRow = playerRow;
                nextCol = playerCol - 1;
            }
            else if (direction == "right")
            {
                nextRow = playerRow;
                nextCol = playerCol + 1;
            }
        }

        private static void ProceedMove(int n,  int nextRow,  int nextCol)
        {
            var nextSymbol = field[nextRow][nextCol];
            if (char.IsDigit(nextSymbol))
            {
                collectedPower += nextSymbol - 48;

            }
            else if (nextSymbol == 'O')
            {  
                TravelingO(n, ref nextRow, ref nextCol);
                
            }

            field[nextRow][nextCol] = 'S';
            field[playerRow][playerCol] = '-';

            playerRow = nextRow;
            playerCol = nextCol;
        }

        private static void TravelingO(int n, ref int nextRow, ref int nextCol)
        {
            field[nextRow][nextCol] = '-';
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    char iterSymbol = field[row][col];
                    if (iterSymbol == 'O')
                    {
                        nextRow = row;
                        nextCol = col;
                    }
                }
            }
        }

    }
}
