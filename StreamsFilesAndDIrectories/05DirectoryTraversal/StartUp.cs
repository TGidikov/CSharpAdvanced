using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05DirectoryTraversal
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string inputDir = Console.ReadLine();
            var files=Directory.GetFiles(inputDir);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);          
            Dictionary<string, Dictionary<string, double>> dictionary =new Dictionary < string, Dictionary< string,double>>();
            FileStream report = new FileStream( $"{desktopPath}./report.txt", FileMode.CreateNew);
          

            using StreamWriter writer = new StreamWriter(report);

            foreach (var filePath in files)
            {
                string fileName = filePath
                    .Split('\\')
                    .Last();
                string fileFormat = filePath
                    .Split(".")
                    .Last();
                var fileInfo = new FileInfo(fileName);
                var fileSize = ((fileInfo.Length));
            

                if (!dictionary.ContainsKey(fileFormat))
                {
                    dictionary[fileFormat] = new Dictionary<string, double>();
                }
               dictionary[fileFormat][fileName] = fileSize;
            }

            foreach (var format in dictionary.OrderByDescending(x=>x.Key.Count()).ThenBy(x=>x.Key))
            {
                writer.WriteLine($".{format.Key}");

                foreach (var kvp in format.Value.OrderBy(x=>x.Value))
                {
                    writer.WriteLine($"--{kvp.Key} - {kvp.Value.ToString("#0,###")}kb");
                }

            }
        }
    }
}
