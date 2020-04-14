using System;
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
            string town = $"{personInfo[3]}";
            
            
            var nameAndBeer = Console.ReadLine().Split();
            string name = nameAndBeer[0];
            int beerAm = int.Parse(nameAndBeer[1]);
            bool drunkOrNot;
            if (nameAndBeer[2]=="drunk")
            {
                drunkOrNot = true;
            }
            else 
            {
                drunkOrNot = false;
            }

            var thirdInput = Console.ReadLine().Split();
            var thirdInputName = $"{thirdInput[0]}";
            var bankBallance = double.Parse(thirdInput[1]);
            var bankName = $"{thirdInput[2]}";



            Tuple<string, string,string> firstTuple = new Tuple<string, string,string>(fullName, address,town);
            Tuple<string, int,bool> secondTuple = new Tuple<string, int,bool>(name, beerAm,drunkOrNot);
            Tuple<string, double,string> thirdTuple = new Tuple<string, double,string>(thirdInputName, bankBallance,bankName);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);

        }
    }
}
