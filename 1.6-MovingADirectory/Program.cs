using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6_MovingADirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.Move(@"C:\west.pfx", @"C:\teste2\west.pfx");
            //DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\west.pfx");
            //directoryInfo.MoveTo(@"C:\teste2\west.pfx");
        }
    }
}
    