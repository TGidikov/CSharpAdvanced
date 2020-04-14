using System;
using System.Collections.Generic;
using System.Linq;

namespace _04FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string query = Console.ReadLine();

            Predicate<int> predicate = query == "odd" ?
                new Predicate<int>((n) => n % 2 != 0) : new
                Predicate<int>((n) => n % 2 == 0);

            var res = new List<int>();

            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                if (predicate(i))
                {
                    res.Add(i);
                }
            }
            Console.WriteLine(String.Join(" ",res));
        }

    }
}
