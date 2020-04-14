using System;
using System.Collections.Generic;
using System.Linq;

namespace _02BasicQueueOperations
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
 
            var input2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            var queue = new Queue<int>(input2);
            var s = input[1];
            var x = input[2];

            for (int i = 0; i <s; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else if(queue.Any())
            {
                Console.WriteLine(queue.Min());
            }
            else
                Console.WriteLine("0");
    






        }





    }
}
