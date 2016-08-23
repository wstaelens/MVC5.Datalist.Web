using System.Web.Optimization;

namespace Datalist.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterScripts(bundles);
            RegisterStyles(bundles);
        }
        private static void RegisterScripts(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/MvcDatalist/Bundle").Include("~/Scripts/MvcDatalist/*.js"));
            bundles.Add(new ScriptBundle("~/Scripts/JQueryUI/Bundle").Include("~/Scripts/JQueryUI/*.js"));
            bundles.Add(new ScriptBundle("~/Scripts/JQuery/Bundle").Include("~/Scripts/JQuery/*.js"));
            bundles.Add(new ScriptBundle("~/Scripts/Shared/Bundle").Include("~/Scripts/Shared/*.js"));
        }
        private static void RegisterStyles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/MvcDatalist/Bundle").Include("~/Content/MvcDatalist/*.css"));
            bundles.Add(new StyleBundle("~/Content/FontAwesome/Bundle").Include("~/Content/FontAwesome/*.css"));
            bundles.Add(new StyleBundle("~/Content/Bootstrap/Bundle").Include("~/Content/Bootstrap/*.css"));
            bundles.Add(new StyleBundle("~/Content/JQueryUI/Bundle").Include("~/Content/JQueryUI/*.css"));
            bundles.Add(new StyleBundle("~/Content/Shared/Bundle").Include("~/Content/Shared/*.css"));
        }
    }
}