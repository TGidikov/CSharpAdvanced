using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                names.Add(input);

               
            }
            Box<string> box = new Box<string>(names);

           var Indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            box.Swap(names, Indexes[0], Indexes[1]);
            Console.WriteLine(box);

        }
    }
}
