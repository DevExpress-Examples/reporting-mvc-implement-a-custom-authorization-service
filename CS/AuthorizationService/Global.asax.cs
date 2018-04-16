using DevExpress.XtraReports.Web.WebDocumentViewer;
using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AuthorizationService {
    public class MvcApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            DevExpress.XtraReports.Web.WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.ReadOnly;
            DefaultWebDocumentViewerContainer.Register<WebDocumentViewerOperationLogger, Services.OperationLogger>();
            DefaultWebDocumentViewerContainer.Register<IWebDocumentViewerAuthorizationService, Services.OperationLogger>();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start(object sender, EventArgs e) {

        }
    }
}
