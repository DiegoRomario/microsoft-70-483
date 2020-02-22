using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_CreateAndUseAFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\test.dat";
            using (Stream fileStream = File.Create(path))
            {
                string myValue = "MyValue";
                byte[] data = Encoding.UTF8.GetBytes(myValue);
                fileStream.Write(data, 0, data.Length);
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
