using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3._4_UpdatingXMLInAProceduralWay
{
    class Program
    {
        static void Main(string[] args)
        {
            String xml = @"<?xml version ='1.0' encoding ='utf-8'?>     
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

            XElement root = XElement.Parse(xml);
            foreach (XElement p in root.Descendants("person"))
            {
                string name = (string)p.Attribute("firstname") + " " + (string)p.Attribute("lastname");
                p.Add(new XAttribute("IsMale", name.Contains("john")));
                XElement contactDetails = p.Element("contactdetails");
                if (!contactDetails.Descendants("phonenumber").Any())
                {
                    contactDetails.Add(new XElement("phonenumber", "001122334455"));
                }
            }
            Console.WriteLine(root.ToString());
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
