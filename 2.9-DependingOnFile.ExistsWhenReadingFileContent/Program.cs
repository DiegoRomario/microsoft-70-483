using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._9_DependingOnFile.ExistsWhenReadingFileContent
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadAllText();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
        private static string ReadAllText()
        {
            string path = @"C:\temp\test.txt";
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            return string.Empty;
        }
    }
}
