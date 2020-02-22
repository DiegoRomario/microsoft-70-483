using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_ImplementingIDisposableAndAFinalizer
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class MuClassUnmangedWrapper : IDisposable
    {
        public FileStream Stream { get; private set; }
        public MuClassUnmangedWrapper()
        {
            this.Stream = File.Open("temp.dat", FileMode.Create);
        }
        ~MuClassUnmangedWrapper()
        {
            Dispose(false);
        }
        public void Close()
        {
            Dispose();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Stream != null)
                {
                    Stream.Close();
                }
            }
        }
    }
}
