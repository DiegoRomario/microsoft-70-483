using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _1._7_UsingSHA256ManagedToCalculateAHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            SHA256 sha256 = SHA256.Create();
            string data = "A paragraph of text";
            byte[] hashA = sha256.ComputeHash(byteConverter.GetBytes(data));
            data = "A paragraph of changed text";
            byte[] hashB = sha256.ComputeHash(byteConverter.GetBytes(data));
            data = "A paragraph of text";
            byte[] hashC = sha256.ComputeHash(byteConverter.GetBytes(data));
            Console.WriteLine(hashA.SequenceEqual(hashB)); // Displays: false
            Console.WriteLine(hashA.SequenceEqual(hashC)); // Displays: true


            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
