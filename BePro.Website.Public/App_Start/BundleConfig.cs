using System.Web;
using System.Web.Optimization;

namespace BePro.Website.Public
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
                      "~/Scripts/respond.js",
                      "~/Scripts/jquery.isotope.js",
                      "~/Scripts/jquery.parallax.js",
                      "~/Scripts/jquery.prettyPhoto.js",
                      "~/Scripts/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/prettyPhoto.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/fonts").Include(
                     "~/Content/font-awesome.min.css",
                     "~/fonts/bpg-mrgvlovani.min.css",
                     "~/fonts/bpg-mrgvlovani-caps.min.css",
                     "~/fonts/OpenSans.css"));

            bundles.Add(new StyleBundle("~/Content/page/prices").Include(
                    "~/Content/Pages/prices.css"));

            bundles.Add(new StyleBundle("~/Content/lobibox").Include(
                 "~/Content/Lobibox/*.css"));

            bundles.Add(new ScriptBundle("~/bundles/lobibox").Include(
                   "~/Scripts/Lobibox/*.js"));
        }
    }
}
