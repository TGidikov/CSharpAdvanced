using System;
using System.Collections.Generic;
using System.Linq;
namespace _02SetsOfElements
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var nm = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();
            var sum = nm[0] + nm[1];
            var first = new HashSet<string>(nm[0]);
            var second = new HashSet<string>(nm[1]);
            
            for (int i = 1; i <= sum; i++)
            {
                var number = Console.ReadLine();

                if (i<=nm[0])
                {
                    first.Add(number);
                }
                if(i>nm[0])
                {
                    second.Add(number);
                }

               
               

                
            }
            var intersect = first.Intersect(second);
            foreach (var kvp in intersect)
            {
                Console.Write(kvp+ " ");
            }


           

        }
    }
}
