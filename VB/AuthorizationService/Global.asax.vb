Imports DevExpress.XtraReports.Web.WebDocumentViewer
Imports System
Imports System.Web.Mvc
Imports System.Web.Optimization
Imports System.Web.Routing

Namespace AuthorizationService

    Public Class MvcApplication
        Inherits Web.HttpApplication

        Protected Sub Application_Start()
            Native.WebDocumentViewerBootstrapper.SessionState = Web.SessionState.SessionStateBehavior.ReadOnly
            Call DefaultWebDocumentViewerContainer.Register(Of WebDocumentViewerOperationLogger, Services.OperationLogger)()
            Call DefaultWebDocumentViewerContainer.Register(Of IWebDocumentViewerAuthorizationService, Services.OperationLogger)()
            Call AreaRegistration.RegisterAllAreas()
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
            RouteConfig.RegisterRoutes(RouteTable.Routes)
            BundleConfig.RegisterBundles(BundleTable.Bundles)
        End Sub

        Protected Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        End Sub
    End Class
End Namespace
