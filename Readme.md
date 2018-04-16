# How to implement a custom authorization service


<p>This example illustrates how to restrict access to specific reports and documents based on an ASP.NET session, making documents available only to users that generated them.<br><br>To do this, register an <strong>OperationLogger</strong> object implementing the <strong>IWebDocumentViewerAuthorizationService</strong> interface and is inherited from the base <a href="https://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsWebWebDocumentViewerWebDocumentViewerOperationLoggertopic">WebDocumentViewerOperationLogger</a> class.</p>

<br/>


