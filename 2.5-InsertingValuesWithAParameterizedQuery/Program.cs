using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_InsertingValuesWithAParameterizedQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        public async Task InsertRowWithParameterizedQuery()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ProgrammingInCSharpConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("INSERT INTO People([FirstName], [LastName], [MiddleName]) VALUES(@firstName, @lastName, @middleName)",connection);
                await connection.OpenAsync();
                command.Parameters.AddWithValue("@firstName", "John");
                command.Parameters.AddWithValue("@lastName", "Doe");
                command.Parameters.AddWithValue("@middleName", "Little");
                int numberOfInsertedRows = await command.ExecuteNonQueryAsync();
                Console.WriteLine("Inserted {0} rows", numberOfInsertedRows);
            }
        }
    }
}
