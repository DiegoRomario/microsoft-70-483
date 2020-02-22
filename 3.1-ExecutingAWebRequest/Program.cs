using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_ExecutingAWebRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create("http://www.microsoft.com");
            WebResponse response = request.GetResponse();
            StreamReader responseStream = new StreamReader(response.GetResponseStream());
            string responseText = responseStream.ReadToEnd();
            Console.WriteLine(responseText); // Displays the HTML of the website
            response.Close();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
