using System;

namespace CreateCustomDataStructures
{
    class StartUp
    {
        static void Main(string[] args)
        {
         var Laina = new CustomList();

            Laina.Add(8);
            Laina.Add(11);
            Laina.Add(20);


            Laina.Swap(0, 2);
            Console.WriteLine(Laina[0]);
            Console.WriteLine(Laina[1]);
            Console.WriteLine(Laina[2]);   
           Console.WriteLine(Laina.peek)
        }
    }
}
