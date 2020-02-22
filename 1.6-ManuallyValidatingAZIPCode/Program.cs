using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1._6_ManuallyValidatingAZIPCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.Write(ValidateZipCodeRegEx("1234AB"));

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
        static bool ValidateZipCode(string zipCode)
        {
            // Valid zipcodes: 1234AB | 1234 AB | 1001 AB
            if (zipCode.Length < 6) return false;
            string numberPart = zipCode.Substring(0, 4);
            int number;
            if (!int.TryParse(numberPart, out number)) return false;

            string characterPart = zipCode.Substring(4);
            if (numberPart.StartsWith("0")) return false;
            if (characterPart.Trim().Length < 2) return false;
            if (characterPart.Length == 3 && characterPart.Trim().Length != 2)
                return false;
            return true;
        }

        static bool ValidateZipCodeRegEx(string zipCode)
        {
            Match match = Regex.Match(zipCode, @"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$", RegexOptions.IgnoreCase);
            return match.Success;
        }

    }
}
