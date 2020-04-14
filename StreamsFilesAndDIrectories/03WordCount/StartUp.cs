using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace _03WordCount
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var list = File.ReadAllLines("words.txt");

            FileStream actualResult = new FileStream("../../../actualResult.txt", FileMode.CreateNew);
            using StreamWriter originalResult = new StreamWriter(actualResult);
            FileStream result2Sorted = new FileStream("../../../result2sorted.txt", FileMode.CreateNew);
            using StreamWriter sortedResult = new StreamWriter(result2Sorted);
           
            
            
            var dictionary = new Dictionary<string, int>();

            var text = File.ReadAllText("text.txt")
                .Replace("-", " ")
                .Replace(".", " ")
                .Replace("?", " ")
                .Replace("!", " ")
                .Replace(",", " ")
                .Replace("'", " ")
                .ToLower()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            foreach (var word in list)
            {
                dictionary[word] = 0;
            }


            for (int i = 0; i < text.Length; i++)
            {
                if (dictionary.ContainsKey(text[i]))
                {
                    dictionary[text[i]] += 1;
                }

            }

            foreach (var kvp in dictionary)
            {
                originalResult.WriteLine($"{kvp.Key} - {kvp.Value}");
                

            }
            foreach (var kvp in dictionary.OrderByDescending(x=>x.Value))
            {
                sortedResult.WriteLine($"{kvp.Key} - {kvp.Value}");


            }
            originalResult.Close();
            sortedResult.Close();
            var result2sortedCompare = File.ReadAllLines("../../../result2sorted.txt");
            var expectedResult = File.ReadAllLines("../../../expectedResult.txt");
            var onlyInResult2sortedCompare = result2sortedCompare.Except(expectedResult);
            File.WriteAllLines("../../../compare.txt", expectedResult.Concat(onlyInResult2sortedCompare));
        }
    }
}
