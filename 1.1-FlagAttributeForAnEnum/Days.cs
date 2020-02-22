using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_FlagAttributeForAnEnum
{
    [Flags]
    enum Days
    {
        None = 4,
        Sunday = 8,
        Monday = 16,
        Tuesday = 32,
        Wednesday =64,
        Thursday = 128,
        Friday =240,
        Saturday = 520
    }

}

