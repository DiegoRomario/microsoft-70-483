using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace _1._7_UsingTheDataContractSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonDataContract p = new PersonDataContract
            {
                Id = 1,
                Name = "John Doe"
            };
            using (Stream stream = new FileStream("data.xml", FileMode.Create))
            {
                var ser = new DataContractSerializer(typeof(PersonDataContract));
                ser.WriteObject(stream, p);

            }
            using (Stream stream = new FileStream("data.xml", FileMode.Open))
            {
                System.Runtime.Serialization.DataContractSerializer ser = new DataContractSerializer(typeof(PersonDataContract));
                PersonDataContract result = (PersonDataContract)ser.ReadObject(stream);
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

    [DataContract]
    public class PersonDataContract
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        private bool isDirty = false;
    }
}
