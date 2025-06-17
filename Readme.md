<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128596459/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T488888)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for MVC - How to Implement a Custom Authorization Service

This example illustrates how to restrict access to specific reports and documents based on an ASP.NET session, making documents available only to users that generated them. To do this, register an `OperationLogger` object implementing the IWebDocumentViewerAuthorizationService interface and is inherited from the base [WebDocumentViewerOperationLogger](https://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsWebWebDocumentViewerWebDocumentViewerOperationLoggertopic) class.

## Documentation

* [Authorized Access to Reports and Documents in a Web Reporting Application](https://docs.devexpress.com/XtraReports/402997/web-reporting/common-features/application-security/user-authorization)

## Files to Review

* [OperationLogger.cs](CS/AuthorizationService/Services/OperationLogger.cs)
* [Global.asax](CS/AuthorizationService/Global.asax)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-mvc-implement-a-custom-authorization-service&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-mvc-implement-a-custom-authorization-service&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
