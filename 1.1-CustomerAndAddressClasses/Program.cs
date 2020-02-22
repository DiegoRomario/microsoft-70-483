using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_CustomerAndAddressClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            var teste = new ShopContext();
            teste.Save();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string FirstName { get; set; }
        [Required, MaxLength(20)]
        public string LastName { get; set; }
        [Required]
        public Address ShippingAddress { get; set; }
        [Required]
        public Address BillingAddress { get; set; }
    }
    public class Address
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string AddressLine1 { get; set; }
        [Required, MaxLength(20)]
        public string AddressLine2 { get; set; }
        [Required, MaxLength(20)]
        public string City { get; set; }
        [RegularExpression(@"^[1 - 9][0 - 9]{3}\s?[a - zA - Z]{2}$")]
        public string ZipCode { get; set; }
    }

    public class ShopContext : DbContext
    {
        public IDbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Make sure the database knows how to handle the duplicate address property
            modelBuilder.Entity<Customer>().HasRequired(bm => bm.BillingAddress)
                .WithMany().WillCascadeOnDelete(false);
        }

        public void Save ()
        {
            ShopContext ctx = new ShopContext();

            Address a = new Address
            {
                AddressLine1 = "Somewhere 1",
                AddressLine2 = "At some floor",
                City = "SomeCity",
                ZipCode = "1111AA"
            };
            Customer c = new Customer()
            {
                //FirstName = "John",
                LastName = "Doe",
                BillingAddress = a,
                ShippingAddress = a,
            };

            var teste = GenericValidator<Customer>.Validate(c);

            ctx.Customers.Add(c);
            ctx.SaveChanges();
        }

    }
    public static class GenericValidator<T>
    {
        public static IList<ValidationResult> Validate(T entity)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(entity, null, null);
            Validator.TryValidateObject(entity, context, results);
            return results;
        }
    }


}

