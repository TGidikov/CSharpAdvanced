using System;
using System.Linq;

namespace _02KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> honor = (name) =>
            {

                Console.WriteLine("Sir "+name);
            };
            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(honor);
        }
    }
}
