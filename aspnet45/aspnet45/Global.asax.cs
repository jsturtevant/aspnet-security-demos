using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace aspnet45
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //MvcHandler.DisableMvcResponseHeader = true;
        }

        //protected void Application_BeginRequest(object sender, EventArgs e)
        //{
        //    var app = sender as HttpApplication;

        //    if (app?.Context != null)
        //    {
        //        HttpContext.Current.Response.Headers.Remove("Server");
        //    }
        //}
    }
}
