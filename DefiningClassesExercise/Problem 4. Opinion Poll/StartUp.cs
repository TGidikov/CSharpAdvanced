using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Family familiy = new Family();
            for (int i = 0; i < n; i++)
            {



                string[] personArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = personArgs[0];
                int age = int.Parse(personArgs[1]);

                Person person = new Person(name, age);

                familiy.AddMember(person);
            }

            HashSet<Person> result = familiy.GetAllPeople();
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }

    }
}
