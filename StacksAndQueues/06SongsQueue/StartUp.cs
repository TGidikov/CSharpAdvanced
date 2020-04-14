using System;
using System.Collections.Generic;
using System.Linq;
namespace _06SongsQueue
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(", ").ToArray();
            var queue = new Queue<string>(input);
            while (queue.Any())
            {
                var commandInfo = Console.ReadLine().Split().ToArray();

                var command = commandInfo[0];

                if (command == "Play")
                {
                    queue.Dequeue();

                }
                else if (command == "Add")
                {
                    var letter = new string[commandInfo.Length-1];
                    for (int i = 0; i < commandInfo.Length-1; i++)
                    {
                        letter[i] = commandInfo[i+1];
                    }
                    var songName = string.Join(" ", letter);
                    if (queue.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                      
                    }
                    else
                    {
                        queue.Enqueue(songName);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                
            }
            Console.WriteLine("No more songs!");

        } 
    }
}
