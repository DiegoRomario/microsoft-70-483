using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_UsingPath.Combine
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"C:\temp";
            string fileName = "test.txt";
            string fullPath = Path.Combine(folder,fileName); 
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
