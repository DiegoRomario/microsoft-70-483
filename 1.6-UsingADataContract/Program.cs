using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _1._6_UsingADataContract
{
    class Program
    {
        static void Main(string[] args)
        {

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
