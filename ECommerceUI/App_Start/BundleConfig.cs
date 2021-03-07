using System.Web;
using System.Web.Optimization;

namespace ECommerceUI
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/shoptemplate").Include(
                      "~/Scripts/jquery-3.3.1.js",
                      "~/Scripts/ShopTemplate/js/jquery-migrate-3.0.0.js",
                      "~/Scripts/ShopTemplate/js/jquery-ui.min.js",
                      "~/Scripts/ShopTemplate/js/popper.min.js",
                      "~/Scripts/ShopTemplate/js/bootstrap.min.js",
                      "~/Scripts/ShopTemplate/js/slicknav.min.js",
                      "~/Scripts/ShopTemplate/js/owl-carousel.js",
                      "~/Scripts/ShopTemplate/js/magnific-popup.js",
                      "~/Scripts/ShopTemplate/js/waypoints.min.js",
                      "~/Scripts/ShopTemplate/js/finalcountdown.min.js",
                      "~/Scripts/ShopTemplate/js/nicesellect.js",
                      "~/Scripts/ShopTemplate/js/scrollup.js",
                      "~/Scripts/ShopTemplate/js/onepage-nav.min.js",
                      "~/Scripts/ShopTemplate/js/easing.js",
                      "~/Scripts/ShopTemplate/js/active.js"
                      ));

            bundles.Add(new StyleBundle("~/style/shoptemplate").Include(
                      "~/Scripts/ShopTemplate/css/bootstrap.css",
                      "~/Scripts/ShopTemplate/css/magnific-popup.css",
                      "~/Scripts/ShopTemplate/css/font-awesome.css",
                      "~/Scripts/ShopTemplate/css/jquery.fancybox.min.css",
                      "~/Scripts/ShopTemplate/css/themify-icons.css",
                      "~/Scripts/ShopTemplate/css/niceselect.css",
                      "~/Scripts/ShopTemplate/css/animate.css",
                      "~/Scripts/ShopTemplate/css/flex-slider.min.css",
                      "~/Scripts/ShopTemplate/css/owl-carousel.css",
                      "~/Scripts/ShopTemplate/css/slicknav.min.css",
                      "~/Scripts/ShopTemplate/css/reset.css",
                      "~/Scripts/ShopTemplate/style.css",
                      "~/Scripts/ShopTemplate/css/responsive.css"
                      ));
        }
    }
}
