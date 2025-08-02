using System.Web.Optimization;

namespace CP2
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.min.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/simple.min.css"));
        }
    }
}
