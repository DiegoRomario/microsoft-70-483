using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_UpdatingRowsWithExecuteNonQuery
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

        public async Task UpdateRows()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ProgrammingInCSharpConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("UPDATE People SET FirstName =’John’",connection);
                await connection.OpenAsync();
                int numberOfUpdatedRows = await command.ExecuteNonQueryAsync();
                Console.WriteLine("Updated {0} rows", numberOfUpdatedRows);
            }
        }
    }
}
