Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace AuthorizationService.Controllers
    Public Class HomeController
        Inherits Controller

        <Authorize> _
        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function About() As ActionResult
            ViewData("Message") = "Your application description page."

            Return View()
        End Function

        Public Function Contact() As ActionResult
            ViewData("Message") = "Your contact page."

            Return View()
        End Function
    End Class
End Namespace
