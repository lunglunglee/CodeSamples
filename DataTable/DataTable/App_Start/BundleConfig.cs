// // Breeze Project
// // Created by Bartosz Rachwal. 
// // Copyright (c) 2016 Bartosz Rachwal. The National Institute of Advanced Industrial Science and Technology, Japan. All rights reserved.

using System.Web.Optimization;

namespace DataTable
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterShared(bundles);

            RegisterHome(bundles);
        }

        private static void RegisterShared(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Shared/jquery").Include(
                "~/Scripts/Shared/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Shared/jqueryval").Include(
                "~/Scripts/Shared/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/Scripts/Shared/modernizr").Include(
                "~/Scripts/Shared/modernizr-*"));

            bundles.Add(new ScriptBundle("~/Scripts/Shared/bootstrap").Include(
                "~/Scripts/Shared/bootstrap.js",
                "~/Scripts/Shared/respond.js"));

            bundles.Add(new StyleBundle("~/Styles/Shared/css").Include(
                "~/Styles/Shared/bootstrap.css",
                "~/Styles/Shared/site.css"));
        }

        private static void RegisterHome(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Home").Include(
                "~/Scripts/Home/Home.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Home/datatables/js").Include(
                "~/Scripts/Home/datatables/js/jquery.dataTables.min.js",
                "~/Scripts/Home/datatables/js/dataTables.bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Scripts/Home/datatables/css").Include(
                "~/Scripts/Home/datatables/css/dataTables.bootstrap.css"));

            bundles.Add(new ScriptBundle("~/Scripts/Home/jquery-ajax-unobtrusive/js").Include(
                "~/Scripts/Home/jquery-ajax-unobtrusive/js/jquery.unobtrusive-ajax.min.js"));
        }
    }
}