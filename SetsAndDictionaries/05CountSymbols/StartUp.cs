using System;
using System.Collections.Generic;
using System.Linq;
namespace _05CountSymbols
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var dic = new SortedDictionary<char, int>();


            char[] input = Console.ReadLine().ToCharArray();

          
            foreach (var letter in input)
            {
                if (dic.ContainsKey(letter))
                {
                    dic[letter]++;
                }
                else
                {
                    dic[letter] = 1;
                }
                

               
            }
            foreach (var kvp in dic)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }

        }
    }
}

