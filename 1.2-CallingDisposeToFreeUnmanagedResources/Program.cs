using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_CallingDisposeToFreeUnmanagedResources
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");
            stream.Dispose();
            File.Delete("temp.dat");



            //The using statement ensures that Dispose is always called.
            //using (StreamWriter sw = File.CreateText("temp.dat"))
            //{
            //    sw.Write("some data");
            //}
            //File.Delete("temp.dat");

        }
    }
}
