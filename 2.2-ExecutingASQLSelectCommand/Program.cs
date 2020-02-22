using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_ExecutingASQLSelectCommand
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
        public async Task SelectDataFromTable()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ProgrammingInCSharpConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM People", connection);
                await connection.OpenAsync();
                SqlDataReader dataReader = await command.ExecuteReaderAsync();

                while (await dataReader.ReadAsync())
                {
                    string formatStringWithMiddleName = "Person({0}) is named {1} {2}{3}";
                    string formatStringWithoutMiddleName = "Person({0}) is named {1}{3}";
                    if ((dataReader["middlename"] == null))
                    {
                        Console.WriteLine(formatStringWithoutMiddleName,
                            dataReader["id"],
                            dataReader["firstname"],
                            dataReader["lastname"]);
                    }
                    else
                    {
                        Console.WriteLine(formatStringWithMiddleName,
                            dataReader["id"],
                            dataReader["firstname"],
                            dataReader["middlename"],
                            dataReader["lastname"]);
                    }
                }
                dataReader.Close();
            }
        }
    }
}
