using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace IteratorsAndComparators
{
    class StartUp
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();
            List<string> elements = command
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToList();
            ListyIterator <string> listyIterator= new ListyIterator<string>(elements);

          
            while (command !="END")
            {

                if(command=="Print")
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                       
                    }
                    

                }
                else if (command == "Move")
                {
                    bool result = listyIterator.Move();
                    Console.WriteLine(result);
                }
                else if (command == "HasNext")
                {
                    bool result = listyIterator.HasNext();
                    Console.WriteLine(result);
                }
                else if (command=="PrintAll")
                {
                    foreach (var item in listyIterator)
                    {
                        Console.Write(item+" ");
                    }

                    Console.WriteLine();
                }

                command = Console.ReadLine();
            }
        }

    }
}
