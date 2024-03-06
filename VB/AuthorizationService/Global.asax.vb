Imports DevExpress.XtraReports.Web.WebDocumentViewer
Imports System
Imports System.Web.Mvc
Imports System.Web.Optimization
Imports System.Web.Routing

Namespace AuthorizationService
    Public Class MvcApplication
        Inherits System.Web.HttpApplication

        Protected Sub Application_Start()
            DevExpress.XtraReports.Web.WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Required
            DefaultWebDocumentViewerContainer.Register(Of WebDocumentViewerOperationLogger, Services.OperationLogger)()
            DefaultWebDocumentViewerContainer.Register(Of IWebDocumentViewerAuthorizationService, Services.OperationLogger)()
			DefaultWebDocumentViewerContainer.Register(Of IExportingAuthorizationService, Services.OperationLogger)()
            AreaRegistration.RegisterAllAreas()
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
            RouteConfig.RegisterRoutes(RouteTable.Routes)
            BundleConfig.RegisterBundles(BundleTable.Bundles)
        End Sub

        Protected Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)

        End Sub
    End Class
End Namespace
