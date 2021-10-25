using System.Web;
using System.Web.Optimization;

namespace Lib4U
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.bundle.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                         "~/Content/bootstrap.css",
                         "~/adminlte/plugins/fontawesome-free/css/all.min.css",
                         "~/adminlte/css/adminlte.min.css",
                         "~/Content/site.css"
                         ));

            bundles.Add(new ScriptBundle("~/adminlte/js").Include(
             "~/adminlte/js/adminlte.min.js"));

            // add user css
            bundles.Add(new StyleBundle("~/User/css").Include(
                "~/Content/User/css/font-awesome.min.css",
                "~/Content/User/css/jquery.accordion.css",
                "~/Content/User/css/mmenu.css",
                "~/Content/User/css/mmenu.positioning.css",
                "~/Content/User/css/responsivetable.css",
                "~/Content/User/css/style.css"
                ));
            bundles.Add(new ScriptBundle("~/User/js").Include(
                "~/Content/User/js/accordion.min.js",
                "~/Content/User/js/bootstrap.min.js",
                "~/Content/User/js/bxslider.min.js",
                "~/Content/User/js/carousel.swipe.min.js",
                "~/Content/User/js/facts.counter.min.js",
                "~/Content/User/js/google.map.js",
                "~/Content/User/js/harvey.min.js",
                "~/Content/User/js/jquery-1.12.4.min.js",
                "~/Content/User/js/jquery-ui.min.js",
                "~/Content/User/js/jquery.easing.1.3.js",
                "~/Content/User/js/main.js",
                "~/Content/User/js/masonry.min.js",
                "~/Content/User/js/mixitup.min.js",
                "~/Content/User/js/mmenu.min.js",
                "~/Content/User/js/owl.carousel.min.js",
                "~/Content/User/js/responsive.table.min.js",
                "~/Content/User/js/responsive.tabs.min.js",
                "~/Content/User/js/waypoints.min.js"
                ));
        }
    }
}
