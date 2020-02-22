using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_UsingElementAt
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck tempRecord = new Deck();
            // Use the indexer's set accessor
            tempRecord[3] = 58.3F;
            tempRecord[5] = 60.1F;

            Console.WriteLine(tempRecord[3].ToString());
            Console.ReadKey();
        }
    }
}
