using System;
using System.Linq;
using System.Collections.Generic;
namespace _03MaximumAndMinimumElelement
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); ;

                var command = input[0];
                if (command==1)
                {
                    var number = input[1];
                    stack.Push(number);
                }
                else if (command==2 && stack.Any() )
                {
                   
                    stack.Pop();
            
                   
                }
                else if(command==3 && stack.Count>0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if(command==4 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }

            }
                  
               Console.WriteLine(String.Join(", ",stack));
            
                
            





        }
    }
}
