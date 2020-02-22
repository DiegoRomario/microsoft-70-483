using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._8_UsingABufferedStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\bufferedStream.txt";
            using (FileStream fileStream = File.Create(path))
            {
                using (BufferedStream bufferedStream = new BufferedStream(fileStream))
                {
                    using (StreamWriter streamWriter = new StreamWriter(bufferedStream))
                    {
                        streamWriter.WriteLine("A line of text.");
                    }
                }
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
