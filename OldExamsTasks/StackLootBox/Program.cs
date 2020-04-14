using System;
using System.Collections.Generic;
using System.Linq;

namespace StackLootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFirstLootBox = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var inputSecondLootBox = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var firstBoxCollection = new Queue<int>(inputFirstLootBox);

            var secondBoxCollection = new Stack<int>(inputSecondLootBox);

            var collection = 0;
            while (firstBoxCollection.Any() && secondBoxCollection.Any())
            {
                var firstbox = firstBoxCollection.Peek();
                var secondbox = secondBoxCollection.Pop();
                var sum = firstbox + secondbox;
                if (sum%2==0)
                {
                    collection += sum;
                    firstBoxCollection.Dequeue();

                }
                else
                {
                    firstBoxCollection.Enqueue(secondbox);
                }





            }
            if (!firstBoxCollection.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }
            if (!secondBoxCollection.Any())
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (collection>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {collection}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {collection}");
            }




        }
    }
}
