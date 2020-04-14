using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSummerCocktail
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputIngridients = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            var inputFreshness = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            var ingrideientsQueue = new Queue<int>(inputIngridients);
            var freshnessStack = new Stack<int>(inputFreshness);

            SortedDictionary<string, int> drinks = new SortedDictionary<string, int>();


            drinks.Add("Mimosa", 0);
            drinks.Add("Daiquiri", 0);
            drinks.Add("Sunshine", 0);
            drinks.Add("Mojito", 0);

            while (ingrideientsQueue.Any() && freshnessStack.Any())
            {
                if (ingrideientsQueue.Peek() == 0)
                {
                    ingrideientsQueue.Dequeue();
                    continue;
                }

                var ingridient = ingrideientsQueue.Dequeue(); ;
                var freshness = freshnessStack.Pop();
               
                var level = ingridient * freshness;
                if (level == 150)
                {
                    drinks["Mimosa"] ++;
                }
                else if (level == 250)
                {
                    drinks["Daiquiri"] ++;
                }
                else if (level == 300)
                {
                    drinks["Sunshine"] ++;
                }
                else if (level == 400)
                {
                    drinks["Mojito"] ++;
                }
                else
                {
                    ingrideientsQueue.Enqueue(ingridient + 5);
                }

            }
            if (drinks["Mimosa"]>0
                && drinks["Daiquiri"] > 0
                && drinks["Sunshine"] > 0
                && drinks["Mojito"] > 0)
            {
                Console.WriteLine("It's party time! The cocktails are ready!");
            }
            else
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");
            }
            if (ingrideientsQueue.Any())
            {
                Console.WriteLine($"Ingredients left: {ingrideientsQueue.Sum()}");
            }
            foreach (var drink in drinks.Where(d=>d.Value>0))
            {
                Console.WriteLine($" # {drink.Key} --> {drink.Value}");
            }




        }
    }
}
