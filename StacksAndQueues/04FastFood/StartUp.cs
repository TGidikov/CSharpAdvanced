using System;
using System.Collections.Generic;
using System.Linq;

namespace _04FastFood
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var food = int.Parse(Console.ReadLine());

            var orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>(orders);
           
            Console.WriteLine(queue.Max());

            int end = queue.Count;
            for (int i = 0; i <end; i++)
            {
                if (food >= queue.Peek())
                {
                    food -= queue.Dequeue();
                }                              
            }
            if (queue.Any())
            {
                Console.Write("Orders left: ");
                Console.WriteLine(String.Join(' ',queue));
                
            }
            else
            {
                
                Console.WriteLine("Orders complete");
            }

        



        }
    }
}