using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_InheritingFromList_T_ToFormACustomCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleCollection demo = new PeopleCollection();
            demo.Add(new Person()
            {
                Age = 10,
                FirstName = "joey",
                LastName = "scott"
            });
            demo.Add(new Person()
            {
                Age = 1,
                FirstName = "johny",
                LastName = "patrick"
            });
            demo.Add(new Person()
            {
                Age = 10,
                FirstName = "nicklas",
                LastName = "cesc"
            });

            foreach (var item in demo)
            {
                Console.WriteLine(item.FirstName.ToString());
            }

            Console.WriteLine("------------------");

            demo.RemoveByAge(10);

            foreach (var item in demo)
            {
                Console.WriteLine(item.FirstName.ToString());
            }

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
    public class PeopleCollection : List<Person>
    {
        public void RemoveByAge(int age)
        {
            for (int index = this.Count - 1; index >= 0; index--)
            {
                if (this[index].Age == age)
                {
                    this.RemoveAt(index);
                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Person p in this)
            {
                sb.AppendFormat("{0}{1} is {2}", p.FirstName, p.LastName, p.Age);
            }
            return sb.ToString();
        }
    }

    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
