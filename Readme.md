<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128596459/16.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T488888)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-mvc-implement-a-custom-authorization-service&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-mvc-implement-a-custom-authorization-service&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
