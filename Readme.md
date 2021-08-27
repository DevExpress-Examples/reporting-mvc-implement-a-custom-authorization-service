<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128596459/17.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T488888)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to implement a custom authorization service


<p>This example illustrates how to restrict access to specific reports and documents based on an ASP.NET session, making documents available only to users that generated them.<br><br>To do this, register an <strong>OperationLogger</strong> object implementing the <strong>IWebDocumentViewerAuthorizationService</strong> interface and is inherited from the base <a href="https://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsWebWebDocumentViewerWebDocumentViewerOperationLoggertopic">WebDocumentViewerOperationLogger</a> class.</p>

<br/>


