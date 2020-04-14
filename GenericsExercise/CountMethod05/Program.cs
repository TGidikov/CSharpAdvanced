using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var element = Console.ReadLine();
                elements.Add(element);

               
            }
            Box<string> box = new Box<string>(elements);

            var elementToCompare = Console.ReadLine();

           var countOfGreater= box.CountGreaterElements(elements, elementToCompare);
            
            Console.WriteLine(countOfGreater);

        }
    }
}
