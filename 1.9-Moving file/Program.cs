using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_Moving_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\test.txt";
            string destPath = @"c:\temp\destTest.txt";
            File.CreateText(path).Close();
            File.Move(path, destPath);
            FileInfo fileInfo = new FileInfo(path);
            fileInfo.MoveTo(destPath);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
