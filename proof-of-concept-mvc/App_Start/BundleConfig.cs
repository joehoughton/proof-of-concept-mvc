namespace proof_of_concept_mvc
    {
    using System.Web.Optimization;

    public class BundleConfig
        {
        public static void RegisterBundles(BundleCollection bundles)
            {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.js"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                     "~/Scripts/Account/error-alert.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/font-awesome.min.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/site.css"));
            }
        }
    }
