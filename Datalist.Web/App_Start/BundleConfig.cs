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
            bundles.Add(new ScriptBundle("~/Scripts/JQueryUI/Bundle").Include("~/Scripts/jquery-ui-{version}.js"));
            bundles.Add(new ScriptBundle("~/Scripts/Datalist/Bundle").Include("~/Scripts/Datalist/datalist.js"));
            bundles.Add(new ScriptBundle("~/Scripts/JQuery/Bundle").Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/Scripts/QUnit/Bundle").Include("~/Scripts/qunit.js"));
        }
        private static void RegisterStyles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/JQueryUI/Theme/Bundle").Include("~/Content/themes/base/all.css"));
            bundles.Add(new StyleBundle("~/Content/Bootstrap/Bundle").Include("~/Content/bootstrap.css"));
            bundles.Add(new StyleBundle("~/Content/Datalist/Bundle").Include("~/Content/Datalist/*.css"));
            bundles.Add(new StyleBundle("~/Content/QUnit/Bundle").Include("~/Content/qunit.css"));
            bundles.Add(new StyleBundle("~/Content/Shared/Bundle").Include("~/Content/site.css"));
        }
    }
}