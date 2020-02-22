using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8_ReadingDataFromAPerformanceCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press escape key to stop");
            using (PerformanceCounter pc =
            new PerformanceCounter("Memory", "Available Bytes"))
            {
                string text = "Available memory: ";
                Console.Write(text);
                do
                {
                    while (!Console.KeyAvailable)
                    {
                        Console.Write(pc.RawValue);
                        Console.SetCursorPosition(text.Length, Console.CursorTop);
                    }
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
        }
    }
}
