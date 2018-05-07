using System.Web;
using System.Web.Optimization;

namespace OjExam.UIPortal
{
    public class BundleConfig
    {
        // 有关捆绑的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //css
            bundles.Add(new StyleBundle("~/Content/Layui/css").Include("~/Content/layui-admin/css/style.css", "~/Content/layui-admin/layui/css/layui.css"));
            bundles.Add(new StyleBundle("~/Content/bootstrap-table/css").Include("~/Content/bootstrap-table/bootstrap-table.css"));
           
            //js
            bundles.Add(new ScriptBundle("~/Content/Layui/js").Include("~/Content/layui-admin/js/notification.js", "~/Content/layui-admin/layui/layui.js"));
            bundles.Add(new ScriptBundle("~/Content/bootstrap-table/js").Include("~/Content/bootstrap-table/bootstrap-table.js", "~/Content/bootstrap-table/bootstrap-table-zh-CN.js"));
        }
    }
}
