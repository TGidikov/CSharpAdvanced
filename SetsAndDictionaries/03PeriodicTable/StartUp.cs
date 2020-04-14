using System;
using System.Collections.Generic;
namespace _03PeriodicTable
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sortedSet = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                for (int j = 0; j <input.Length; j++)
                {
                    sortedSet.Add(input[j]);
                }

            }
            foreach (var item in sortedSet)
            {
                Console.Write(item+" ");
            }
        }
    }
}
