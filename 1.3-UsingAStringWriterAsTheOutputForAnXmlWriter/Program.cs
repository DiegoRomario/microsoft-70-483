using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _1._3_UsingAStringWriterAsTheOutputForAnXmlWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringWriter = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                writer.WriteStartElement("book");
                writer.WriteElementString("price", "19.95");
                writer.WriteEndElement();
                writer.Flush();
            }
            string xml = stringWriter.ToString();
            Console.Write(xml);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
