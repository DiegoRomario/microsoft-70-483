using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8_DeletingAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\test.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
