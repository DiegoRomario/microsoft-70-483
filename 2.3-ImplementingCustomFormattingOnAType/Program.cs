using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_ImplementingCustomFormattingOnAType
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

    class Person
    {
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

       
        public string ToString(string format)
        {
            if (string.IsNullOrWhiteSpace(format) || format == "G") format = "FL";
            format = format.Trim().ToUpperInvariant();
            switch (format)
            {
                case "FL":
                    return FirstName + " " + LastName;
                case "LF":
                    return LastName + " " + FirstName;
                case "FSL":
                    return FirstName + ", " + LastName;
                case "LSF":
                    return LastName + ", " + FirstName;
                default:
                    throw new FormatException(String.Format("The '{0}' format string is not supported.", format));
            }
        }
    }

}
