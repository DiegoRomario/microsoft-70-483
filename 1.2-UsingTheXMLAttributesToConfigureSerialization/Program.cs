using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _1._2_UsingTheXMLAttributesToConfigureSerialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Order), new Type[] { typeof(VIPOrder) });
            string xml;
            using (StringWriter stringWriter = new StringWriter())
            {
                Order order = CreateOrder();
                serializer.Serialize(stringWriter, order);
                xml = stringWriter.ToString();
                Console.WriteLine(xml);
            }
            using (StringReader stringReader = new StringReader(xml))
            {
                Order o = (Order)serializer.Deserialize(stringReader);
                // Use the order
            }

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
        private static Order CreateOrder()
        {
            Product p1 = new Product { ID = 1, Description = "p2"};
            Product p2 = new Product { ID = 2, Description = "p3"};
            Order order = new VIPOrder
            {
                ID = 4,
                Description = "Order for John Doe. Use the nice giftwrap",
                OrderLines = new List<OrderLine>
                {
                    new OrderLine { ID = 5, Amount = 1, Product = p1},
                    new OrderLine { ID = 6 ,Amount = 10, Product = p2},
                }
            };
            return order;
        }
    }

    [Serializable]
    public class Order
    {
        [XmlAttribute]
        public int ID { get; set; }
        [XmlIgnore]
        public bool IsDirty { get; set; }
        [XmlArray("Lines")]
        [XmlArrayItem("OrderLine")]
        public List<OrderLine> OrderLines { get; set; }
    }
    [Serializable]
    public class VIPOrder : Order
    {
        public string Description { get; set; }
    }
    [Serializable]
    public class OrderLine
    {
        [XmlAttribute]
        public int ID { get; set; }
        [XmlAttribute]
        public int Amount { get; set; }
        [XmlElement("OrderedProduct")]
        public Product Product { get; set; }
    }
    [Serializable]
    public class Product
    {

        public Product()
        {
            this.Price = 80;
        }
        [XmlAttribute]
        public int ID { get; set; }
        private decimal Price { get; set; }
        public string Description { get; set; }
    }
}
