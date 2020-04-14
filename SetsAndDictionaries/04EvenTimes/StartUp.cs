using System;
using System.Collections.Generic;


namespace _04EvenTimes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<int,int>();

            for (int i = 0; i < n; i++)
            { int number = int.Parse(Console.ReadLine());
                if (!dictionary.ContainsKey(number))
                {
                    dictionary[number] = 0;
                }
                dictionary[number]++;
                
            }
            foreach (var kvp in dictionary)
            {
                if (kvp.Value%2==0)
                {
                    Console.WriteLine(kvp.Key);
                    break;
                }
            }
        }
    }
}
