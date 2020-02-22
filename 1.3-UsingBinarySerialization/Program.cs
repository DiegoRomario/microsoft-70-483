using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_UsingBinarySerialization
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
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("data.bin", FileMode.Create))
            {
                formatter.Serialize(stream, p);
            }
            using (Stream stream = new FileStream("data.bin", FileMode.Open))
            {
                 Person dp = (Person)formatter.Deserialize(stream);
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

    [Serializable]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NonSerialized]
        private bool isDirty = false;
    }

}
