using System;
using System.Linq;

namespace _01ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {

            var names = Console.ReadLine().Split().ToArray();
            Action<string> print = messege =>
                Console.WriteLine(messege);
            for (int i = 0; i < names.Length; i++)
            {
                print(names[i]);
            }
        

        } }
}
