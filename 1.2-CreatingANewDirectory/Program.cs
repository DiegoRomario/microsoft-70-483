using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_CreatingANewDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\miau");
            var directoryInfo = new DirectoryInfo(@"C:\miau2");
            directoryInfo.Create();
        }
    }
}
