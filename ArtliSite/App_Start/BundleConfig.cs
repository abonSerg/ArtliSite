using System.Web.Optimization;

namespace ArtliSite
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/style.css",
                "~/Content/bootstrap.min.css",
                "~/Content/core.css",
                "~/Content/custom.css",
                "~/Content/font-awesome.min.css",
                "~/Content/icofont.css",
                "~/Content/responsive.css",
                "~/Content/plugins/animate-slider.css",
                "~/Content/plugins/animate.css",
                "~/Content/plugins/jquery-ui.min.css",
                "~/Content/plugins/jquery.mb.YTPlayer.min.css",
                "~/Content/plugins/jquery.yu2fvl.css",
                "~/Content/plugins/meanmenu.css",
                "~/Content/plugins/owl.carousel.css",
                "~/Content/plugins/owl.theme.default.min.css",
                "~/Content/plugins/slick.css",
                "~/Content/shortcode/default.css",
                "~/Content/shortcode/footer.css",
                "~/Content/shortcode/header.css",
                "~/Content/shortcode/preloader.css",
                "~/Content/shortcode/shortcodes.css",
                "~/Content/shortcode/slider.css")); ;
            //"~/Content/site.css"));
        }
    }
}
