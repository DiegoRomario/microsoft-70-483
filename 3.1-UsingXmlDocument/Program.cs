using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _3._1_UsingXmlDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml = 
                        @"<?xml version ='1.0' encoding ='utf - 8' ?>     
                        <people>     
                            <person firstname ='john' lastname ='doe'>        
                                <contactdetails>        
                                    <emailaddress> john@unknown.com </emailaddress>           
                                </contactdetails>           
                            </person>           
                            <person firstname ='jane' lastname ='doe'>              
                                <contactdetails>              
                                    <emailaddress> jane@unknown.com </emailaddress>                 
                                    <phonenumber> 001122334455 </phonenumber>                 
                               </contactdetails>                 
                            </person>                 
                        </people>";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            XmlNodeList nodes = doc.GetElementsByTagName("person");
            // Output the names of the people in the document
            foreach (XmlNode node in nodes)
            {
                string firstName = node.Attributes["firstname"].Value;
                string lastName = node.Attributes["lastname"].Value;
                Console.WriteLine("Name: {0}{1}", firstName, lastName);
            }
            // Start creating a new node
            XmlNode newNode = doc.CreateNode(XmlNodeType.Element, "person", "");
            XmlAttribute firstNameAttribute = doc.CreateAttribute("firstname");
            firstNameAttribute.Value = "Foo";
            XmlAttribute lastNameAttribute = doc.CreateAttribute("lastname");
            lastNameAttribute.Value = "Bar";
            newNode.Attributes.Append(firstNameAttribute);
            newNode.Attributes.Append(lastNameAttribute);
            doc.DocumentElement.AppendChild(newNode);
            Console.WriteLine("Modified xml...");
            doc.Save(Console.Out);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
