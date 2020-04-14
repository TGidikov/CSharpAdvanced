using System;
using System.IO;
using System.IO.Compression;

namespace _06ZipAndExtract
{
    class StartUp
    {
        static void Main(string[] args)
        {
          ZipFile.CreateFromDirectory("../../../copyFolder", "./myArchive.zip");
            ZipFile.ExtractToDirectory("./myArchive.zip", "./");
        }
    }
}
