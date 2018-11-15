<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/AuthorizationService/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/AuthorizationService/Controllers/HomeController.vb))
* [Global.asax.cs](./CS/AuthorizationService/Global.asax.cs) (VB: [Global.asax.vb](./VB/AuthorizationService/Global.asax.vb))
* [Constants.cs](./CS/AuthorizationService/Services/Constants.cs) (VB: [Constants.vb](./VB/AuthorizationService/Services/Constants.vb))
* **[OperationLogger.cs](./CS/AuthorizationService/Services/OperationLogger.cs) (VB: [OperationLogger.vb](./VB/AuthorizationService/Services/OperationLogger.vb))**
* [Index.cshtml](./CS/AuthorizationService/Views/Home/Index.cshtml)
<!-- default file list end -->
# How to implement a custom authorization service


<p>This example illustrates how to restrict access to specific reports and documents based on an ASP.NET session, making documents available only to users that generated them.<br><br>To do this, register an <strong>OperationLogger</strong> object implementing the <strong>IWebDocumentViewerAuthorizationService</strong> interface and is inherited from the base <a href="https://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsWebWebDocumentViewerWebDocumentViewerOperationLoggertopic">WebDocumentViewerOperationLogger</a> class.</p>

<br/>


