using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7_UsingCodeFirstToMapAClassToTheDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PeopleContext ctx = new PeopleContext())
            {
                ctx.People.Add(new Person() { Id = 1, Name = "John Doe" });
                ctx.SaveChanges();
            }
            using (PeopleContext ctx = new PeopleContext())
            {
                Person person = ctx.People.SingleOrDefault(p => p.Id == 1);
                Console.WriteLine(person.Name);
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
    public class PeopleContext : DbContext
    {
        public IDbSet<Person> People { get; set; }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
