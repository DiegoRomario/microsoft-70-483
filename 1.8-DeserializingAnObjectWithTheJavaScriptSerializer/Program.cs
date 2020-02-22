using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace _1._8_DeserializingAnObjectWithTheJavaScriptSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = "{ 'name':'John', 'age':30, 'car':null }";
            var serializer = new JavaScriptSerializer();
            //var result = serializer.Deserialize<Dictionary<string, object>>(json);
           var result = serializer.Deserialize(json,typeof(Dictionary<string, object>));
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
