using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingACustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenAndParse("");
        }
        public static string OpenAndParse(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new OrderProcessingException(1, "Filename is required");
            return File.ReadAllText(fileName);
        }
    }

}
