﻿using System.Web.Optimization;

namespace MVC5Bootstrap.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                         "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css",
                      "~/Content/font-awesome/css/font-awesome.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquerymobile").Include(
                "~/Scripts/jquery.mobile-1.4.5.js",
                "~/Scripts/iscroll.js",
                "~/Scripts/MVC5BootstrapApp.js"
                ));

            bundles.Add(new StyleBundle("~/Content/mobilecss").Include(
                        "~/Content/jquery.mobile*"
                        ));
        }
    }

}
