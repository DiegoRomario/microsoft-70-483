using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3._4_CreatingXMLWithTheXElementClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new XElement("Child1");
            teste.SetAttributeValue("teste", 1);
            XElement root = new XElement("Root",
            new List<XElement>
            {
                teste,
                new XElement("Child2"),
                new XElement("Child3")
            },
            new XAttribute("MyAttribute", 42));
            root.Save("test.xml");

            Console.WriteLine(root.ToString());

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
