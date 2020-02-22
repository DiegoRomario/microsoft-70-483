using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7_ListingAllTheFilesInADirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach (string file in Directory.GetFiles(@"C:\GitRepository\datapar-visual-rodopar-webapp", "*css*", SearchOption.AllDirectories))
            //{
            //    Console.WriteLine(file);
            //}
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\GitRepository\datapar-visual-rodopar-webapp\Nova pasta");
            foreach (FileInfo fileInfo in directoryInfo.GetFiles())
            {
                if (fileInfo.Extension == ".css" && new FileInfo(fileInfo.FullName).Length == 3 ) { 
                Console.WriteLine(fileInfo.FullName);
                }
            }
            Console.ReadKey();
        }
    }
}
