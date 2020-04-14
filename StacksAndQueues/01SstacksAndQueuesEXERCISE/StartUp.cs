using System;
using System.Collections.Generic;
using System.Linq;

namespace _01SstacksAndQueuesEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var nPush = input[0];
            var sPop = input[1];
            var x = input[2];


            var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(input2);
            for (int i = 0; i < sPop; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Any()) 
            {
                Console.WriteLine(stack.Min()); 
            }
            else
                Console.WriteLine("0");






        }
    }
}
