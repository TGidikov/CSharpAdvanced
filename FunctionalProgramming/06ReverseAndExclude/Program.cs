using System;
using System.Linq;

namespace _06ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());
            var revCol = collection.Reverse().ToArray();

            foreach (var number in revCol)
            {
                if (!(number%n==0))
                {
                    Console.Write(string.Join(" ",number)+" ");
                }
            }

        }
    }
}
