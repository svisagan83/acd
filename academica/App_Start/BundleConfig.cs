using System.Web;
using System.Web.Optimization;

namespace academica
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = false;

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular-*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            //My project required bundles
            bundles.Add(new ScriptBundle("~/bundles/plugin").Include(                      
                      "~/assets/js/jquery-migrate-1.2.1.js",
                      "~/assets/plugins/bootstrap/js/bootstrap.min.js",
                      "~/assets/js/modernizr.custom.js",
                      "~/assets/js/waypoints.min.js",
                      "~/assets/plugins/nouislider/jquery.nouislider.all.min.js",
                      "~/assets/plugins/sliderpro/js/jquery.sliderPro.min.js",
                      "~/assets/plugins/owl-carousel/owl-carousel.min.js",
                      "~/assets/plugins/isotope/jquery.isotope.min.js",
                      "~/assets/plugins/prettyphoto/js/jquery.prettyPhoto.js",
                      "~/assets/plugins/datetimepicker/jquery.datetimepicker.js",
                      "~/assets/plugins/jelect/jquery.jelect.js",
                      "~/assets/plugins/rendro-easy-pie-chart/dist/jquery.easypiechart.min.js",
                      "~/assets/plugins/switcher/js/bootstrap-select.js",
                      "~/assets/plugins/switcher/js/dmss.js", 
                      "~/assets/js/cssua.min.js", 
                      "~/assets/js/wow.min.js",
                      "~/assets/js/custom.min.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                    "~/assets/css/theme.css",  
                    "~/assets/css/sidebar.css",
                    "~/assets/css/blog.css",   
                    "~/assets/css/responsive.css",
                    "~/assets/css/color.css",
                    "~/assets/css/debugging.css",
                    "~/assets/css/index.css",
                    "~/assets/css/master.css",
                    "~/assets/plugins/sliderpro/css/slider-pro.css",
                    "~/assets/plugins/bootstrap/bootstrap.css",
                    "~/assets/plugins/isotope/isotope.css",
                    "~/assets/plugins/validation/validation-2.2.min.css", 
                    "~/assets/plugins/owl-carousel/owl.carousel.css",
                    "~/assets/plugins/owl-carousel/owl.transitions.css",
                    "~/assets/plugins/owl-carousel/owl.theme.css", 
                    "~/assets/plugins/prettyphoto/css/prettyPhoto.css",
                    "~/assets/plugins/yamm/yamm.css", 
                    "~/assets/plugins/datetimepicker/jquery.datetimepicker.css",
                    "~/assets/plugins/animate/animate.css",
                    "~/assets/plugins/jelect/main.css",                    
                     "~/assets/plugins/switcher/css/switcher.css"));

        }
    }
}
