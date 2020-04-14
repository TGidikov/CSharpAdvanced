using System;

namespace CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new CustomStack();
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Peek()); ;
        }
    }
}
