using System;
using System.Collections.Generic;
using System.Linq;

namespace _09ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxNumber = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var listOfNumbers = new List<int>();
            bool Filter(int x, int y) => x % y != 0;

            for (int i = 1; i <= maxNumber; i++)
            {
                var isSearchNumber = true;

                foreach (var divider in dividers)
                {
                    if (Filter(i, divider))
                    {
                        isSearchNumber = false;
                        break;
                    }
                }

                if (isSearchNumber)
                {
                    listOfNumbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}
