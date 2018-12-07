using System.Web;
using System.Web.Optimization;

namespace smarthomeautomation
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/css/bootstrap.css", //Bootstrap core CSS
                "~/Content/css/font-awesome.min.css", //
                "~/Content/css/mega_menu.css", //mega_menu
                "~/Content/css/slider.css", //slider
                "~/Content/css/animate.min.css", //animate
                "~/Content/css/owl-carousel/owl.carousel.css", //Owl Carousel Assets
                "~/Content/css/owl-carousel/owl.theme.css", //Owl Carousel Assets
                "~/Content/css/jquery.mCustomScrollbar.css", //Scrollbar 
                "~/Content/css/my_style.css", //Custom styles for this template
                "~/Content/css/my_style_responsive.css", //Custom styles for this template
                "~/Content/css/ie10-viewport-bug-workaround.css" //IE10 viewport hack for Surface/desktop Windows 8 bug
                ));
            bundles.Add(new StyleBundle("~/Content/innercss").Include("~/Content/css/ion.rangeSlider.css", //rangeSlider
                "~/Content/css/ion.rangeSlider.skinFlat.css" //rangeSlider
                ));
            bundles.Add(new ScriptBundle("~/bundles/index").Include(
                "~/scripts/jquery.min.js",
                "~/scripts/mega_menu.js",
                "~/scripts/bootstrap.min.js",
                "~/scripts/owl.carousel.js",
                "~/scripts/jquery.mCustomScrollbar.js",
                "~/scripts/main.js"));

            bundles.Add(new ScriptBundle("~/bundles/index").Include(
                "~/scripts/jquery.min.js",
                "~/scripts/mega_menu.js",
                "~/scripts/bootstrap.min.js",
                "~/scripts/owl.carousel.js",
                "~/scripts/jquery.mCustomScrollbar.js",
                "~/scripts/main.js"));

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


        }
    }
}
