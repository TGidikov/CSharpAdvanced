using System;

namespace CustomDoublyLinkedList
{
    class StartUp
    {
        static void Main(string[] args)
        {

            DoublLinkedList list = new DoublLinkedList();

            list.AddFirst(10);
            list.AddLast(20);
            list.ForEach(n => Console.WriteLine(n));
            
        }
    }
}
