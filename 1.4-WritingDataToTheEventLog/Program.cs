using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4_WritingDataToTheEventLog
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!EventLog.SourceExists("MySource"))
            {
                EventLog.CreateEventSource("MySource", "MyNewLog");
                Console.WriteLine("CreatedEventSource");
                Console.WriteLine("Please restart application");
                Console.ReadKey();
                return;
            }
            EventLog myLog = new EventLog();
            myLog.Source = "MySource";
            myLog.WriteEntry("Log event!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
