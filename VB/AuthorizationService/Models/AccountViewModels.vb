Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations

Namespace AuthorizationService.Models
    Public Class ExternalLoginConfirmationViewModel
        <Required, Display(Name := "Email")> _
        Public Property Email() As String
    End Class

    Public Class ExternalLoginListViewModel
        Public Property ReturnUrl() As String
    End Class

    Public Class SendCodeViewModel
        Public Property SelectedProvider() As String
        Public Property Providers() As ICollection(Of System.Web.Mvc.SelectListItem)
        Public Property ReturnUrl() As String
        Public Property RememberMe() As Boolean
    End Class

    Public Class VerifyCodeViewModel
        <Required> _
        Public Property Provider() As String

        <Required, Display(Name := "Code")> _
        Public Property Code() As String
        Public Property ReturnUrl() As String

        <Display(Name := "Remember this browser?")> _
        Public Property RememberBrowser() As Boolean

        Public Property RememberMe() As Boolean
    End Class

    Public Class ForgotViewModel
        <Required, Display(Name := "Email")> _
        Public Property Email() As String
    End Class

    Public Class LoginViewModel
        <Required, Display(Name := "Email"), EmailAddress> _
        Public Property Email() As String

        <Required, DataType(DataType.Password), Display(Name := "Password")> _
        Public Property Password() As String

        <Display(Name := "Remember me?")> _
        Public Property RememberMe() As Boolean
    End Class

    Public Class RegisterViewModel
        <Required, EmailAddress, Display(Name := "Email")> _
        Public Property Email() As String

        <Required, StringLength(100, ErrorMessage := "The {0} must be at least {2} characters long.", MinimumLength := 6), DataType(DataType.Password), Display(Name := "Password")> _
        Public Property Password() As String

        <DataType(DataType.Password), Display(Name := "Confirm password"), Compare("Password", ErrorMessage := "The password and confirmation password do not match.")> _
        Public Property ConfirmPassword() As String
    End Class

    Public Class ResetPasswordViewModel
        <Required, EmailAddress, Display(Name := "Email")> _
        Public Property Email() As String

        <Required, StringLength(100, ErrorMessage := "The {0} must be at least {2} characters long.", MinimumLength := 6), DataType(DataType.Password), Display(Name := "Password")> _
        Public Property Password() As String

        <DataType(DataType.Password), Display(Name := "Confirm password"), Compare("Password", ErrorMessage := "The password and confirmation password do not match.")> _
        Public Property ConfirmPassword() As String

        Public Property Code() As String
    End Class

    Public Class ForgotPasswordViewModel
        <Required, EmailAddress, Display(Name := "Email")> _
        Public Property Email() As String
    End Class
End Namespace
