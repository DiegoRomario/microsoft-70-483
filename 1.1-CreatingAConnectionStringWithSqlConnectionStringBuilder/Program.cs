using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_CreatingAConnectionStringWithSqlConnectionStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.DataSource = @"Password=123;Persist Security Info=True;User ID=321;Initial Catalog=db_teste;Data Source=teste";
            sqlConnectionStringBuilder.InitialCatalog = "ProgrammingInCSharp";
            string connectionString = sqlConnectionStringBuilder.ToString();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
