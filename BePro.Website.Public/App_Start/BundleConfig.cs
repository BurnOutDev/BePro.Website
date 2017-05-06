using System.Web.Optimization;

namespace BePro.Website.Public
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/css/style.css").Include(
                "~/Content/Css/bootstrap.css",
                "~/Content/Css/prettyPhoto.css",
                "~/Content/Css/Site.css",
                "~/Content/Css/fonts/font-awesome.css",
                "~/Content/Css/fonts/bpg-mrgvlovani.min.css",
                "~/Content/Css/fonts/bpg-mrgvlovani-caps.min.css",
                "~/Content/Css/fonts/OpenSans.css",
                "~/Content/Css/Lobibox/lobibox.css"
            ));

            bundles.Add(new ScriptBundle("~/js/main.js").Include(
                "~/Content/Scripts/TweenMax.min.js",
                "~/Content/Scripts/modernizr-2.8.3.js",
                "~/Content/Scripts/jquery-3.1.1.js",
                "~/Content/Scripts/bootstrap.js",
                "~/Content/Scripts/respond.js",
                "~/Content/Scripts/jquery.prettyPhoto.js",
                "~/Content/Scripts/jquery.parallax.js",
                "~/Content/Scripts/jquery.isotope.js",
                "~/Content/Scripts/main.js",
                "~/Content/Scripts/lobibox/lobibox.js"
            ));
        }
    }
}
