using System;
using System.Collections.Generic;
using System.Linq;

namespace SantaSPresentFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var materialsForCrafting = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var magicLevel = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

           
            var materialsBox = new Stack<int>(materialsForCrafting);

            var magicValues = new Queue<int>(magicLevel);

            var craftedToys = new Dictionary<string, int>();
            Dictionary<string, int> whishList = new Dictionary<string, int>();
            whishList.Add("Doll", 150);
            whishList.Add("Wooden train", 250);
            whishList.Add("Teddy bear", 300);
            whishList.Add("Bicycle", 400);

            while (materialsBox.Any()  && magicValues.Any())
            {
                int totalMagicLevel = materialsBox.Peek() * magicValues.Peek();
                if (whishList.ContainsValue(totalMagicLevel))
                {
                    var item = whishList.Where(x => x.Value == totalMagicLevel).First();
                    materialsBox.Pop();
                   magicValues.Dequeue();
                    if (!craftedToys.ContainsKey(item.Key))
                    {
                        craftedToys.Add(item.Key, 0);
                    }
                    craftedToys[item.Key]++;
                }
                else if ((materialsBox.Peek() * magicValues.Peek()) < 0)
                {
                    int result = materialsBox.Peek() + magicValues.Peek();
                    materialsBox.Pop();
                    magicValues.Dequeue();
                    materialsBox.Push(result);
                }
                else if (totalMagicLevel > 0)
                {
                    magicValues.Dequeue();
                    materialsBox.Push(materialsBox.Pop() + 15);
                }
                else if (totalMagicLevel == 0)
                {
                    if (materialsBox.Peek() == 0)
                    {
                        materialsBox.Pop();
                    }
                    if (magicValues.Peek() == 0)
                    {
                        magicValues.Dequeue();
                    }
                    continue;
                }
                continue;
            }

            if ((craftedToys.ContainsKey("Doll") && craftedToys.ContainsKey("Wooden train") ||
                 (craftedToys.ContainsKey("Teddy bear") && craftedToys.ContainsKey("Bicycle"))))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if (materialsBox.Any())
            {

                Console.Write("Materials left: ");
                Console.WriteLine(string.Join(", ", materialsBox));
            }
            if (magicValues.Any())
            {

                Console.Write("Magic left: ");
                Console.WriteLine(string.Join(", ", magicValues));
            }





            foreach (var toy in craftedToys.OrderBy(kp=>kp.Key))
            {
                Console.WriteLine($"{toy.Key}: {toy.Value}");
            }




        }
    }
}

