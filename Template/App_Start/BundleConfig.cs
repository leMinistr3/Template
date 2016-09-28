using System;
using System.Web;
using System.Web.Optimization;

namespace Template
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // JavaScript File
            bundles.Add(new ScriptBundle("~/js/jquery").Include(
                        "~/Bundles/jQuery/jquery-1.10.2.min.js",
                        "~/Bundles/jQuery/jquery.validate.min.js",
                        "~/Bundles/jQuery/jquery.validate.unobtrusive.min.js"));

            bundles.Add(new ScriptBundle("~/js/bootstrap").Include(
                        "~/Bundles/Bootstrap/JS/bootstrap.min.js",
                        "~/Bundles/Bootstrap/JS/respond.js"));

            bundles.Add(new ScriptBundle("~/js/kendo").Include(
                        "~/Bundles/Kendo/JS/kendo.all.min.js",
                        "~/Bundles/Kendo/JS/kendo.aspnetmvc.min.js"));

            // StyleSheet File
            bundles.Add(new StyleBundle("~/css/bootstrap").Include(
                      "~/Bundles/Bootstrap/CSS/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/css/kendo").Include(
                      "~/Bundles/Kendo/CSS/kendo.common.min.css",
                      "~/Bundles/Kendo/CSS/kendo.default.min.css"));

            bundles.Add(new StyleBundle("~/css/gsft").Include(
                       "~/Bundles/GSFT/CSS/Site.css"));
        }
    }
}
