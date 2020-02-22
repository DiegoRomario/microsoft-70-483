using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_ImplicitlyConvertingAnObjectToABaseType
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            object o = client;
            IDisposable d = client;
        }
    }
}
