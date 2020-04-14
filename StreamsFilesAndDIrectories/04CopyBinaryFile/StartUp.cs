using System;
using System.IO;

namespace _04CopyBinaryFile
{
    class StartUp
    {
        static void Main(string[] args)
        {
            const int DeffSize = 4096;
         using  var reader = new FileStream("./copyMe.png", FileMode.Open);

         using var writer = new FileStream("../../../copied.png", FileMode.CreateNew);

            byte[] buffer = new byte[DeffSize];

            while (reader.CanRead)
            {
              int bytesRead=  reader.Read(buffer, 0, buffer.Length);

                if (bytesRead==0)
                {
                    break;
                }
                writer.Write(buffer, 0, buffer.Length);
            }


        }
    }
}
