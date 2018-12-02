using System.Web;
using System.Web.Optimization;

namespace smarthomeautomation
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/css/bootstrap.css",
                "~/Content/css/font-awesome.min.css",
                "~/Content/css/mega_menu.css",
                "~/Content/css/slider.css",
                "~/Content/css/animate.min.css",
                "~/Content/css/owl-carousel/owl.carousel.css",
                "~/Content/css/owl-carousel/owl.theme.css",
                "~/Content/css/jquery.mCustomScrollbar.css",
                "~/Content/css/my_style.css",
                "~/Content/css/my_style_responsive.css",
                //"https://fonts.googleapis.com/css?family=Montserrat:100,200,300,400,500,600,700,800,900",
                //"https://fonts.googleapis.com/css?family=Raleway:100,200,300,400,500,600,700,800,900",

                "~/Content/css/ie10-viewport-bug-workaround.css"));
            bundles.Add(new ScriptBundle("~/bundles/index").Include(
                "~/scripts/jquery.min.js",
                "~/scripts/mega_menu.js", "~/scripts/mega_menu.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));
        }
    }
}
