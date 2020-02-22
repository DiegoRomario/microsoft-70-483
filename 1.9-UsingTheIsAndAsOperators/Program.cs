using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_UsingTheIsAndAsOperators
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        void OpenConnection(DbConnection connection)
        {
            if (connection is SqlConnection)
            {
                // run some special code
            }
        }
        void LogStream(Stream stream)
        {
            MemoryStream memoryStream = stream as MemoryStream;
            if (memoryStream != null)
            {
                // ....
            }
        }
    }

    
}
