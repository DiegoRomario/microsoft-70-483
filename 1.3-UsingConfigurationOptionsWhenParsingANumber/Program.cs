using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_UsingConfigurationOptionsWhenParsingANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo english = new CultureInfo("En");
            CultureInfo dutch = new CultureInfo("Nl");
            string value = "19,95";
            decimal d = decimal.Parse(value, NumberStyles.Currency, dutch);
            decimal e = decimal.Parse(value, NumberStyles.Currency, english);
            Console.WriteLine(d.ToString(dutch)); 
            Console.WriteLine(e.ToString(english)); 
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
