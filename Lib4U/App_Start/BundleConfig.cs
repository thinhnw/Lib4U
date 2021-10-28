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
                         "~/Content/Site.css"
                         ));

            bundles.Add(new ScriptBundle("~/adminlte/js").Include(
             "~/adminlte/js/adminlte.min.js"));

            // add user css
            bundles.Add(new StyleBundle("~/Client/css").Include(
                            "~/Content/Client/css/font-awesome.min.css",
                            "~/Content/Client/css/mmenu.css",
                            "~/Content/Client/css/mmenu.positioning.css",
                            "~/Content/Client/css/jquery.accordion.css",
                            "~/Content/Client/style.css"
                            ));
            bundles.Add(new ScriptBundle("~/Client/js").Include(
                            "~/Content/Client/js/jquery-1.12.4.min.js",
                            "~/Content/Client/js/jquery-ui.min.js",
                            "~/Content/Client/js/jquery.easing.1.3.js",
                            "~/Content/Client/js/bootstrap.min.js",
                            "~/Content/Client/js/mmenu.min.js",
                            "~/Content/Client/js/harvey.min.js",
                            "~/Content/Client/js/waypoints.min.js",
                            "~/Content/Client/js/facts.counter.min.js",
                            "~/Content/Client/js/mixitup.min.js",
                            "~/Content/Client/js/owl.carousel.min.js",
                            "~/Content/Client/js/accordion.min.js",
                            "~/Content/Client/js/responsive.tabs.min.js",
                            "~/Content/Client/js/responsive.table.min.js",
                            "~/Content/Client/js/masonry.min.js",
                            "~/Content/Client/js/carousel.swipe.min.js",
                            "~/Content/Client/js/bxslider.min.js",
                            "~/Content/Client/js/main.js"
                ));
        }
    }
}
