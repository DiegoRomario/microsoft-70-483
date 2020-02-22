using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6_WritingDataToTheEventLog
{
    class Program
    {
        static void Main(string[] args)
        {
            EventLog applicationLog = new EventLog("Application", ".", "testEventLogEvent");
            applicationLog.EntryWritten += (sender, e) =>
            {
                Console.WriteLine(e.Entry.Message);
            };
            applicationLog.EnableRaisingEvents = true;
            applicationLog.WriteEntry("Test message", EventLogEntryType.Information);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
