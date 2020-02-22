using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_OpeningATextFileAndReadingTheContent
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\test.dat";
            using (StreamReader streamWriter = File.OpenText(path))
            {
                Console.WriteLine(streamWriter.ReadLine()); // Displays: MyValue
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
