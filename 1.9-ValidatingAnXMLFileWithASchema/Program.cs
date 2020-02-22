using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace _1._9_ValidatingAnXMLFileWithASchema
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            ValidateXML();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        public static void ValidateXML()
        {
            string xsdPath = "person.xsd";
            string xmlPath = "person.xml";

            XmlReader reader = XmlReader.Create(xmlPath);
            XmlDocument document = new XmlDocument();
            document.Schemas.Add("", xsdPath);
            document.Load(reader);
            ValidationEventHandler eventHandler =
                new ValidationEventHandler(ValidationEventHandler);
            document.Validate(eventHandler);
        }
        static void ValidationEventHandler(object sender,
            ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    Console.WriteLine("Error: {0}", e.Message);
                    break;
                case XmlSeverityType.Warning:
                    Console.WriteLine("Warning {0}", e.Message);
                    break;
            }
        }
    }


}
