using System;
using System.Linq;
namespace _05AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            string  input;
      
            while ((input=Console.ReadLine()) !="end")
            {
              

                if (input=="add")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] += 1;
                    }
                }
                else if (input == "multiply")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] *=2;
                    }
                }
                else if (input=="subtract")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -= 1;
                    }
                }
                else if (input=="print")
                {
                  foreach(var number in numbers)
                    {
                        Console.Write(string.Join("",number)+" ");
                    }

                    Console.WriteLine();
                }
               

            }





        }
    }
}
