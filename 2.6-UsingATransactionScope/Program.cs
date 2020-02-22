using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _2._6_UsingATransactionScope
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ProgrammingInCSharpConnection"].ConnectionString;

            using (TransactionScope transactionScope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command1 = new SqlCommand("INSERT INTO People([FirstName], [LastName], [MiddleInitial])VALUES('John', 'Doe', null)", connection);
                    SqlCommand command2 = new SqlCommand("INSERT INTO People([FirstName], [LastName], [MiddleInitial])VALUES('Jane','Doe', null)", connection);
                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                }
                transactionScope.Complete();
            }

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
