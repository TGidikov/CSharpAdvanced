using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var malesSequence = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var femalesSequence = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var females = new Queue<int>(femalesSequence);

            var males = new Stack<int>(malesSequence);
            var matches = 0;

            while (females.Count > 0 && males.Count > 0)
            {
                if (females.Peek() <= 0)
                {
                    females.Dequeue();
                    continue;
                }

                if (males.Peek() <= 0)
                {
                    males.Pop();
                    continue;
                }
                if (females.Peek() % 25 == 0)
                {
                    females.Dequeue();
                    if (females.Any())
                    {
                        females.Dequeue();
                        
                    }
                    continue;
                }
                if (males.Peek() % 25 == 0)
                {
                    males.Pop();
                    if (males.Any())
                    {
                        males.Pop();
                       

                    }
                    continue;
                }

              

         

                if (males.Peek()==females.Peek())
                {
                    males.Pop();
                    females.Dequeue();
                    matches++;
                }
                else if (males.Peek() != females.Peek())
                {
                    females.Dequeue();
                    males.Push(males.Pop()-2);
                }

            }

            Console.WriteLine($"Matches: {matches}");



            if (males.Any())
            {
                Console.Write("Males left: ");
                Console.WriteLine(string.Join(", ", males));
            }
            else
            {
                Console.WriteLine("Males left: none");
            }


            if (females.Any())
            {
                Console.Write("Females left: ");
                Console.WriteLine(string.Join(", ",females));
            }
            else
            {
                Console.WriteLine("Females left: none");
              
            }

            



        }
    }
}
