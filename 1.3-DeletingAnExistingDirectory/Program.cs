using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_DeletingAnExistingDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Directory.Exists(@"C:\miau"))
            {
                Directory.Delete(@"C:\miau2");
            }
            var directoryInfo = new DirectoryInfo(@"C:\miau");
            if (directoryInfo.Exists)
            {
                directoryInfo.Delete();
            }
        }
    }
}
