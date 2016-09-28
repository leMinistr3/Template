using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Template
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Widget",
                url: "{controller}/{action}",
                namespaces: new string[] { "Template.Widget" });

            routes.MapRoute(
                name: "Master Page",
                url: "{pageName}",
                defaults: new { controller = "Master", action = "Index" },
                namespaces: new string[] { "Template.Template" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Master", action = "Index" },
                namespaces: new string[] { "Template.Template" });
        }
    }
}
