using System;
using System.Collections.Generic;
using System.Linq;
namespace _01Unique_Usernames
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();

                names.Add(name);


            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
