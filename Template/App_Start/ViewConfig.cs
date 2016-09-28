using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Template.App_Start
{
    public class ViewConfig
    {
        public static void RegisterViewEngines(ICollection<IViewEngine> engines)
        {
            engines.Add(new RazorViewEngine
            {
                PartialViewLocationFormats = new[] { "~/Widget/Views/Shared/{1}/{0}.cshtml", "~/Template/Views/Shared/{1}/{0}.cshtml" },
                ViewLocationFormats = new[] { "~/Widget/Views/{1}/{0}.cshtml", "~/Template/Views/{1}/{0}.cshtml" }
            });
        }
    }
}