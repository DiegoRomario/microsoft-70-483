using _1._8_UsingTheDataContractJsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5_UsingDictionary_TKey_TValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Id = 1, Name = "Name1" };
            Person p2 = new Person { Id = 2, Name = "Name2" };
            Person p3 = new Person { Id = 3, Name = "Name3" };
            var dict = new Dictionary<int, Person>();
            dict.Add(p1.Id, p1);
            dict.Add(p2.Id, p2);
            dict.Add(p3.Id, p3);
            foreach (KeyValuePair<int, Person> v in dict)
            {
                Console.WriteLine("{0}: {1}", v.Key, v.Value.Name);
            }
            dict[5] = new Person { Id = 4, Name = "Name4" };
            Console.WriteLine("----");
            foreach (KeyValuePair<int, Person> v in dict)
            {
                Console.WriteLine("{0}: {1}", v.Key, v.Value.Name);
            }
            Person result;
            Console.WriteLine("----");
            if (!dict.TryGetValue(5, out result))
            {
                Console.WriteLine("No person with a key of 5 can be found");
            }
            else
            {
                Console.WriteLine("{0}: {1}", result.Id, result.Name);
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
