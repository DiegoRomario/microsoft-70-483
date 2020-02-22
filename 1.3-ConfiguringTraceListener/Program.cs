using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_ConfiguringTraceListener
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream outputFile = File.Create("tracefile.txt");
            TextWriterTraceListener textListener =
                new TextWriterTraceListener(outputFile);
            TraceSource traceSource = new TraceSource("myTraceSource",
                SourceLevels.All);
            traceSource.Listeners.Clear();
            traceSource.Listeners.Add(textListener);
            traceSource.TraceInformation("Trace output");
            traceSource.Flush();
            traceSource.Close();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
