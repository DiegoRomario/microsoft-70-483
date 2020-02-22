using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace _1._2_ExportingAPublicKey
{
    class Program
    {
        static void Main(string[] args)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string publicKeyXML = rsa.ToXmlString(true);
            string privateKeyXML = rsa.ToXmlString(true);
            Console.WriteLine(publicKeyXML);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(privateKeyXML);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
