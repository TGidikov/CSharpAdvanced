﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {

            var personInfo = Console.ReadLine()
            .Split();
            string fullName = $"{personInfo[0]} {personInfo[1]}";
            string address = $"{personInfo[2]}";

            var nameAndBeer = Console.ReadLine().Split();
            string name = nameAndBeer[0];
            int beerAm = int.Parse(nameAndBeer[1]);


            var thirdInput = Console.ReadLine().Split();
            var firstArgument = int.Parse(thirdInput[0]);
            var secondArgument = double.Parse(thirdInput[1]);




            Tuple<string, string> firstTuple = new Tuple<string, string>(fullName, address);
            Tuple<string, int> secondTuple = new Tuple<string, int>(name, beerAm);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(firstArgument, secondArgument);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);

        }
    }
}
