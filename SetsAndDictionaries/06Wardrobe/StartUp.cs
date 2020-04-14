using System;
using System.Collections.Generic;
using System.Linq;

namespace _06Wardrobe
{
    class StartUp
    {
        static void Main(string[] args)
        {


            var wardrobe = new Dictionary<string,Dictionary<string,int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <n; i++)
            {
                string[] inputArg = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();


                string color = inputArg[0];
                string[] clother = inputArg[1]
                    .Split(',',StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();


                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();

                }
                foreach(var cloth in clother)
                {

                    if (!wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color][cloth] = 0;
                    }
                    wardrobe[color][cloth]++;

                }






            }
            string[] searchArg = Console.ReadLine().Split().ToArray();
            string searchColor = searchArg[0];
            string searchCloth = searchArg[1];

            foreach (var cdp in wardrobe)
            {
                string color = cdp.Key;
                Dictionary <string,int>clothes = cdp.Value;
                Console.WriteLine($"{color} clothes:");

                foreach (var cqp in clothes )
                {
                    string cloth = cqp.Key;
                    int qty = cqp.Value;
                    if (color==searchColor && cloth==searchCloth)
                    {
                        Console.WriteLine($"* {cloth} - {qty} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth} - {qty}");
                    }

                }
            }



        }

    }
}
