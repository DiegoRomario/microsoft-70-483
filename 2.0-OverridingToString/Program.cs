using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._0_OverridingToString
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Person p = new Person("John", "Doe");
            Console.WriteLine(p); // Displays ‘John Doe’
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
        public override string ToString()
        {
            return FirstName + LastName;
        }
    }
}
