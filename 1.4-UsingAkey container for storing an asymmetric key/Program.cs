using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _1._4_UsingAkey_container_for_storing_an_asymmetric_key
{
    class Program
    {
        static void Main(string[] args)
        {
            string containerName = "SecretContainer";
            CspParameters csp = new CspParameters() { KeyContainerName = containerName };
            byte[] encryptedData;

            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes("My Secret Data!");

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                encryptedData = RSA.Encrypt(dataToEncrypt, false);
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
