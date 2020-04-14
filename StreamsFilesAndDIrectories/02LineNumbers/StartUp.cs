using System;
using System.IO;
using System.Linq;
namespace _02LineNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {



            
            var lines = File.ReadAllLines("./text.txt");
          
        
     
            for (int i = 0; i < lines.Length; i++)
            {
                int punc = 0;

                int letter = 0;
             
                string currLine = lines[i];
                
                for (int j = 0; j < currLine.Length; j++)
                {
                    
                    char currsymbol = currLine[j];


                    if (Char.IsLetter(currsymbol))
                    {
                        letter++;
                    }
                    if (Char.IsPunctuation(currsymbol))
                    {
                        punc++;
                    }

                    
                }
               
                
                lines[i] = ($"Line{i+1}:{currLine}({letter})({punc})");
                
               

            }
            File.WriteAllLines("../../../output.txt", lines);












        }

        
    }
}
