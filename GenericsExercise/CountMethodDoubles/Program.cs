using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> elements = new List<double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var element = double.Parse(Console.ReadLine());
                elements.Add(element);

               
            }
            Box<double> box = new Box<double>(elements);

            var elementToCompare = double.Parse(Console.ReadLine());

           var countOfGreater= box.CountGreaterElements(elements, elementToCompare);
            
            Console.WriteLine(countOfGreater);

        }
    }
}
