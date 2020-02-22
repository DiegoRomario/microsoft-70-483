using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace _3._2_UsingAnXPathQuery
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
            doc.LoadXml(xml); // Can be found in Listing 4-43
            XPathNavigator nav = doc.CreateNavigator();
            string query = "//people/person[@firstname='jane']";
            XPathNodeIterator iterator = nav.Select(query);
            Console.WriteLine(iterator.Count); // Displays 1
            while (iterator.MoveNext())
            {
                string firstName = iterator.Current.GetAttribute("firstname","");
                string lastName = iterator.Current.GetAttribute("lastname","");
                Console.WriteLine("Name: {0}{1}", firstName, lastName);
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
