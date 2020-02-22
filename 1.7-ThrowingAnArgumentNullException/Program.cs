using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingAnArgumentNullException
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenAndParse("");
        }
        public static string OpenAndParse(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentNullException("10", "demo teste");
            Console.ReadKey();
            return File.ReadAllText(fileName);
        }
    }
}
