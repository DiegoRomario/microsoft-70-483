using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5_ReadingDataFromTheEventLog
{
    class Program
    {
        static void Main(string[] args)
        {
            EventLog log = new EventLog("MyNewLog");
            Console.WriteLine("Total entries: " + log.Entries.Count);
            EventLogEntry last = log.Entries[log.Entries.Count - 1];
            Console.WriteLine("Index:   " + last.Index);
            Console.WriteLine("Source:  " + last.Source);
            Console.WriteLine("Type:    " + last.EntryType);
            Console.WriteLine("Time:    " + last.TimeWritten);
            Console.WriteLine("Message: " + last.Message);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
