using System;
using System.Web;
using System.Web.Mvc;
using HiQo.StaffManagement.Web.Filters;

namespace HiQo.StaffManagement.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new GlobalErrorHandler());
            filters.Add(new LogActionFilter());
        }
    }

}
