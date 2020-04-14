using System;
using System.Collections.Generic;
using System.Linq;

namespace _05FashionButique
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var clothesInBox = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var currentSum = 0;
            var racksCount = 1;
            var capacity = int.Parse(Console.ReadLine());


            var clothes = new Stack<int>(clothesInBox);

            for (int i = 0; i < clothesInBox.Length; i++)
            {

                if (currentSum + clothes.Peek() <= capacity)
                {
                    if (currentSum == capacity && clothes.Any())
                    {
                        racksCount += 1;
                    }
                    currentSum += clothes.Pop();

                }

                else if ((currentSum + clothes.Peek()) > capacity)
                {

                    racksCount += 1;
                    currentSum = 0;
                    currentSum += clothes.Pop();

                }



            }

            Console.WriteLine(racksCount);

        }      
       
       }

    }




