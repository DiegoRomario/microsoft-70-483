using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace _1._8_UsingTheDataContractJsonSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person
            {
                Id = 1,
                Name = "John Doe"
            };
            using (MemoryStream stream = new MemoryStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
                ser.WriteObject(stream, p);
                stream.Position = 0;
                StreamReader streamReader = new StreamReader(stream);
                Console.WriteLine(streamReader.ReadToEnd()); 
                stream.Position = 0;
                Person result = (Person)ser.ReadObject(stream);
            }
            Console.ReadKey();
        }
    }
    [DataContract]
    public class Person
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
