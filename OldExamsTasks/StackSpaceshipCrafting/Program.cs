using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSpaceshipCrafting
{
    class Program
    {

        static void Main(string[] args)
        {
            var inputLiquids = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var inputItems = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var liquids = new Queue<int>(inputLiquids);
            var items = new Stack<int>(inputItems);


            int glass = 0;
            int aluminium = 0;
            int lithium = 0;
            int carbonFiber = 0;

            while (liquids.Any() && items.Any())
            {
                int currLiquid = liquids.Dequeue();
                int curritem = items.Pop();
                int sum =  currLiquid+curritem;

                if (sum == 25)
                {
                    glass++;

                }
                else if (sum == 50)
                {
                    aluminium++;

                }
                else if (sum == 75)
                {
                    lithium++;
                }
                else if (sum == 100)
                {
                    carbonFiber++;
                }
                else
                {
                    items.Push(curritem + 3);
                }
            }

            if (glass > 0 && aluminium > 0 && lithium > 0 && carbonFiber > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquids.Any())
            {
              
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (items.Any())
            {
              
                Console.WriteLine($"Physical items left: {string.Join(", ", items)}");
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }

            Console.WriteLine($"Aluminium: {aluminium}");
            Console.WriteLine($"Carbon fiber: {carbonFiber}");
            Console.WriteLine($"Glass: {glass}");
            Console.WriteLine($"Lithium: {lithium}");
        }



    }
}

