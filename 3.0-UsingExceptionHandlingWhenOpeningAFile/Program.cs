using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0_UsingExceptionHandlingWhenOpeningAFile
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
            try
            {
                return File.ReadAllText(path);
            }
            catch (DirectoryNotFoundException ex) {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex) {
                Console.WriteLine(ex.Message);
            }
            return string.Empty;
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
