﻿using System.Web;
using System.Web.Mvc;

namespace _2._2_TheDynamicKeywordInASP.NET_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
