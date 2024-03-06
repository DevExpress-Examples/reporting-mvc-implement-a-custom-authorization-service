Imports System.Web
Imports System.Web.Optimization

Namespace AuthorizationService
    Public Class BundleConfig
        ' For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        Public Shared Sub RegisterBundles(ByVal bundles As BundleCollection)
            bundles.Add((New ScriptBundle("~/bundles/jquery")).Include("~/Scripts/jquery-{version}.js"))

            bundles.Add((New ScriptBundle("~/bundles/jqueryval")).Include("~/Scripts/jquery.validate*"))

            ' Use the development version of Modernizr to develop with and learn from. Then, when you're
            ' ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add((New ScriptBundle("~/bundles/modernizr")).Include("~/Scripts/modernizr-*"))

            bundles.Add((New ScriptBundle("~/bundles/bootstrap")).Include("~/Scripts/bootstrap.js", "~/Scripts/respond.js"))

            bundles.Add((New StyleBundle("~/Content/css")).Include("~/Content/bootstrap.css", "~/Content/site.css"))
        End Sub
    End Class
End Namespace
