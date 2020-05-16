using System.Web;
using System.Web.Optimization;

namespace AppMercurial
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = false;
            #region JS
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                 "~/Scripts/bootstrap/bootstrap.bundle.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-ui").Include(
                        "~/Scripts/jquery-ui/datepicker.js"));

            bundles.Add(new ScriptBundle("~/bundles/perfect-scrollbar").Include(
                        "~/Scripts/perfect-scrollbar/perfect-scrollbar.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/moment").Include(
                        "~/Scripts/moment/min/moment.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/peity").Include(
                        "~/Scripts/peity/jquery.peity.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bracket").Include(
                        "~/Scripts/bracket/bracket.js"));
            #endregion


            #region CSS

            bundles.Add(new StyleBundle("~/Content/fortawesome").Include(
                     "~/Content/fortawesome/all.min.css"));

            bundles.Add(new StyleBundle("~/Content/ionicons").Include(
                     "~/Content/ionicons/css/ionicons.min.css"));


            bundles.Add(new StyleBundle("~/Content/bracket").Include(
                     "~/Content/bracket.css"));


            #endregion






        }
    }
}
