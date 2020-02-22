using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_UsingTheTraceSourceClass
{
    class Program
    {
        static void Main(string[] args)
        {
            TraceSource traceSource = new TraceSource("myTraceSource",SourceLevels.All);
            traceSource.TraceInformation("Tracing application..");
            traceSource.TraceEvent(TraceEventType.Critical, 0, "Critical trace");
            traceSource.TraceData(TraceEventType.Information, 1,
                new object[] { "a", "b", "c" });
            traceSource.Flush();
            traceSource.Close();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
