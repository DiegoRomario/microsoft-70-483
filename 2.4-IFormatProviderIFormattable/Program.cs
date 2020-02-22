using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_IFormatProviderIFormattable
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new Person("15.00", "teste");
            teste.GetFormat(System.Globalization.CultureInfo.CurrentCulture.GetType());
            //teste.ToString("C", System.Globalization.CultureInfo.CurrentCulture);

            var miau = int.Parse("tete", teste);


        }
    }
}

