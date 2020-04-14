using System;
using System.Collections.Generic;
using System.Linq;
namespace _09SimpleTextEditor
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var stack = new Stack<string>();

            var text = string.Empty;
            for (int i = 0; i < n; i++)
            {

                var CommandInfo = Console.ReadLine().Split(new char[] { ' ' } ,StringSplitOptions.RemoveEmptyEntries).ToArray();

                var command = CommandInfo[0];
                if (command=="1")
                {
                    text += CommandInfo[1];
                    stack.Push(text);
                }
                else if (command == "2")
                {
                   var  Erase = int.Parse(CommandInfo[1]);

                    text = text.Substring(0, text.Length - Erase);

                    stack.Push(text);

                }
                else if (command == "3")
                {
                    var index = int.Parse(CommandInfo[1]);
                    Console.WriteLine(text[index-1]);



                }
                else if (command == "4")
                {
                    text = stack.Pop();
                    if (stack.Count > 0)
                    {
                        text = stack.Peek();
                    }
                    else
                    {
                        text = string.Empty;
                    }
                }


            }


        }
    }
}
