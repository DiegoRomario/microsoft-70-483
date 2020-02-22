using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_UsingOtherPathMethodsToParseAPath
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\subdir\file.txt";
            Console.WriteLine(Path.GetDirectoryName(path)); // Displays C:\temp\subdir
            Console.WriteLine(Path.GetExtension(path)); // Displays .txt
            Console.WriteLine(Path.GetFileName(path)); // Displays file.txt
            Console.WriteLine(Path.GetPathRoot(path)); // Displays C:\
            // The Path class can also help you when you need to temporarily store some data.You can
            // use GetRandomFileName to create a random file or directory name.GetTempPath returns the
            // location of the current user’s temporary folder, and GetTempFileName creates a temporary
            // file that you can then use to store some data in. 
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
