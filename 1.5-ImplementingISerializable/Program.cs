using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _1._5_ImplementingISerializable
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonComplex p = new PersonComplex
            {
                Id = 1,
                Name = "John Doe"
            };
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("data.bin", FileMode.Create))
            {
                formatter.Serialize(stream, p);
            }
            using (Stream stream = new FileStream("data.bin", FileMode.Open))
            {
                
                PersonComplex dp = (PersonComplex)formatter.Deserialize(stream);
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
    [Serializable]
    public class PersonComplex : ISerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private bool isDirty = false;
        public PersonComplex() { }
        protected PersonComplex(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetInt32("Value1");
            Name = info.GetString("Value2");
            isDirty = info.GetBoolean("Value3");
        }
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Value1", Id);
            info.AddValue("Value2", Name);
            info.AddValue("Value3", isDirty);
        }
    }
}
