﻿using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ContosoUniversity.DAL;
using System.Data.Entity.Infrastructure.Interception;

namespace ContosoUniversity
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ServerConfig.RegisterCloudConfig();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DbInterception.Add(new SchoolInterceptorTransientErrors());
            DbInterception.Add(new SchoolInterceptorLogging());
        }
    }
}
