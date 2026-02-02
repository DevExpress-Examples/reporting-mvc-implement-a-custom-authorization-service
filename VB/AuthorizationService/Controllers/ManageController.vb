Imports System
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Web
Imports System.Web.Mvc
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin.Security
Imports AuthorizationService.Models

Namespace AuthorizationService.Controllers

    <System.Web.Mvc.AuthorizeAttribute>
    Public Class ManageController
        Inherits System.Web.Mvc.Controller

        Private _signInManager As AuthorizationService.ApplicationSignInManager

        Private _userManager As AuthorizationService.ApplicationUserManager

        Public Sub New()
        End Sub

        Public Sub New(ByVal userManager As AuthorizationService.ApplicationUserManager, ByVal signInManager As AuthorizationService.ApplicationSignInManager)
            Me.UserManager = userManager
            Me.SignInManager = signInManager
        End Sub

        Public Property SignInManager As ApplicationSignInManager
            Get
                Return If(Me._signInManager Is Nothing, Me.HttpContext.GetOwinContext().[Get](Of AuthorizationService.ApplicationSignInManager)(), Me._signInManager)
            End Get

            Private Set(ByVal value As ApplicationSignInManager)
                Me._signInManager = value
            End Set
        End Property

        Public Property UserManager As ApplicationUserManager
            Get
                Return If(Me._userManager Is Nothing, Me.HttpContext.GetOwinContext().GetUserManager(Of AuthorizationService.ApplicationUserManager)(), Me._userManager)
            End Get

            Private Set(ByVal value As ApplicationUserManager)
                Me._userManager = value
            End Set
        End Property

        '
        ' GET: /Manage/Index
        Public Async Function Index(ByVal message As AuthorizationService.Controllers.ManageController.ManageMessageId?) As Task(Of System.Web.Mvc.ActionResult)
            Me.ViewData("StatusMessage") = If(message = AuthorizationService.Controllers.ManageController.ManageMessageId.ChangePasswordSuccess, "Your password has been changed.", If(message = AuthorizationService.Controllers.ManageController.ManageMessageId.SetPasswordSuccess, "Your password has been set.", If(message = AuthorizationService.Controllers.ManageController.ManageMessageId.SetTwoFactorSuccess, "Your two-factor authentication provider has been set.", If(message = AuthorizationService.Controllers.ManageController.ManageMessageId.[Error], "An error has occurred.", If(message = AuthorizationService.Controllers.ManageController.ManageMessageId.AddPhoneSuccess, "Your phone number was added.", If(message = AuthorizationService.Controllers.ManageController.ManageMessageId.RemovePhoneSuccess, "Your phone number was removed.", ""))))))
            Dim userId = Me.User.Identity.GetUserId()
            Dim model = New AuthorizationService.Models.IndexViewModel With {.HasPassword = Me.HasPassword(), .PhoneNumber = Await Me.UserManager.GetPhoneNumberAsync(userId), .TwoFactor = Await Me.UserManager.GetTwoFactorEnabledAsync(userId), .Logins = Await Me.UserManager.GetLoginsAsync(userId), .BrowserRemembered = Await Me.AuthenticationManager.TwoFactorBrowserRememberedAsync(userId)}
            Return Me.View(model)
        End Function

        '
        ' POST: /Manage/RemoveLogin
        <System.Web.Mvc.HttpPostAttribute>
        <System.Web.Mvc.ValidateAntiForgeryTokenAttribute>
        Public Async Function RemoveLogin(ByVal loginProvider As String, ByVal providerKey As String) As Task(Of System.Web.Mvc.ActionResult)
            Dim message As AuthorizationService.Controllers.ManageController.ManageMessageId?
            Dim result = Await Me.UserManager.RemoveLoginAsync(Me.User.Identity.GetUserId(), New Microsoft.AspNet.Identity.UserLoginInfo(loginProvider, providerKey))
            If result.Succeeded Then
                Dim user = Await Me.UserManager.FindByIdAsync(Me.User.Identity.GetUserId())
                If user IsNot Nothing Then
                    Await Me.SignInManager.SignInAsync(user, isPersistent:=False, rememberBrowser:=False)
                End If

                message = AuthorizationService.Controllers.ManageController.ManageMessageId.RemoveLoginSuccess
            Else
                message = AuthorizationService.Controllers.ManageController.ManageMessageId.[Error]
            End If

            Return Me.RedirectToAction("ManageLogins", New With {.Message = message})
        End Function

        '
        ' GET: /Manage/AddPhoneNumber
        Public Function AddPhoneNumber() As ActionResult
            Return Me.View()
        End Function

        '
        ' POST: /Manage/AddPhoneNumber
        <System.Web.Mvc.HttpPostAttribute>
        <System.Web.Mvc.ValidateAntiForgeryTokenAttribute>
        Public Async Function AddPhoneNumber(ByVal model As AuthorizationService.Models.AddPhoneNumberViewModel) As Task(Of System.Web.Mvc.ActionResult)
            If Not Me.ModelState.IsValid Then
                Return Me.View(model)
            End If

            ' Generate the token and send it
            Dim code = Await Me.UserManager.GenerateChangePhoneNumberTokenAsync(Me.User.Identity.GetUserId(), model.Number)
            If Me.UserManager.SmsService IsNot Nothing Then
                Dim message = New Microsoft.AspNet.Identity.IdentityMessage With {.Destination = model.Number, .Body = "Your security code is: " & code}
                Await Me.UserManager.SmsService.SendAsync(message)
            End If

            Return Me.RedirectToAction("VerifyPhoneNumber", New With {.PhoneNumber = model.Number})
        End Function

        '
        ' POST: /Manage/EnableTwoFactorAuthentication
        <System.Web.Mvc.HttpPostAttribute>
        <System.Web.Mvc.ValidateAntiForgeryTokenAttribute>
        Public Async Function EnableTwoFactorAuthentication() As Task(Of System.Web.Mvc.ActionResult)
            Await Me.UserManager.SetTwoFactorEnabledAsync(Me.User.Identity.GetUserId(), True)
            Dim user = Await Me.UserManager.FindByIdAsync(Me.User.Identity.GetUserId())
            If user IsNot Nothing Then
                Await Me.SignInManager.SignInAsync(user, isPersistent:=False, rememberBrowser:=False)
            End If

            Return Me.RedirectToAction("Index", "Manage")
        End Function

        '
        ' POST: /Manage/DisableTwoFactorAuthentication
        <System.Web.Mvc.HttpPostAttribute>
        <System.Web.Mvc.ValidateAntiForgeryTokenAttribute>
        Public Async Function DisableTwoFactorAuthentication() As Task(Of System.Web.Mvc.ActionResult)
            Await Me.UserManager.SetTwoFactorEnabledAsync(Me.User.Identity.GetUserId(), False)
            Dim user = Await Me.UserManager.FindByIdAsync(Me.User.Identity.GetUserId())
            If user IsNot Nothing Then
                Await Me.SignInManager.SignInAsync(user, isPersistent:=False, rememberBrowser:=False)
            End If

            Return Me.RedirectToAction("Index", "Manage")
        End Function

        '
        ' GET: /Manage/VerifyPhoneNumber
        Public Async Function VerifyPhoneNumber(ByVal phoneNumber As String) As Task(Of System.Web.Mvc.ActionResult)
            Dim code = Await Me.UserManager.GenerateChangePhoneNumberTokenAsync(Me.User.Identity.GetUserId(), phoneNumber)
            ' Send an SMS through the SMS provider to verify the phone number
            Return If(Equals(phoneNumber, Nothing), Me.View("Error"), Me.View(New AuthorizationService.Models.VerifyPhoneNumberViewModel With {.PhoneNumber = phoneNumber}))
        End Function

        '
        ' POST: /Manage/VerifyPhoneNumber
        <System.Web.Mvc.HttpPostAttribute>
        <System.Web.Mvc.ValidateAntiForgeryTokenAttribute>
        Public Async Function VerifyPhoneNumber(ByVal model As AuthorizationService.Models.VerifyPhoneNumberViewModel) As Task(Of System.Web.Mvc.ActionResult)
            If Not Me.ModelState.IsValid Then
                Return Me.View(model)
            End If

            Dim result = Await Me.UserManager.ChangePhoneNumberAsync(Me.User.Identity.GetUserId(), model.PhoneNumber, model.Code)
            If result.Succeeded Then
                Dim user = Await Me.UserManager.FindByIdAsync(Me.User.Identity.GetUserId())
                If user IsNot Nothing Then
                    Await Me.SignInManager.SignInAsync(user, isPersistent:=False, rememberBrowser:=False)
                End If

                Return Me.RedirectToAction("Index", New With {.Message = AuthorizationService.Controllers.ManageController.ManageMessageId.AddPhoneSuccess})
            End If

            ' If we got this far, something failed, redisplay form
            Me.ModelState.AddModelError("", "Failed to verify phone")
            Return Me.View(model)
        End Function

        '
        ' GET: /Manage/RemovePhoneNumber
        Public Async Function RemovePhoneNumber() As Task(Of System.Web.Mvc.ActionResult)
            Dim result = Await Me.UserManager.SetPhoneNumberAsync(Me.User.Identity.GetUserId(), Nothing)
            If Not result.Succeeded Then
                Return Me.RedirectToAction("Index", New With {.Message = AuthorizationService.Controllers.ManageController.ManageMessageId.[Error]})
            End If

            Dim user = Await Me.UserManager.FindByIdAsync(Me.User.Identity.GetUserId())
            If user IsNot Nothing Then
                Await Me.SignInManager.SignInAsync(user, isPersistent:=False, rememberBrowser:=False)
            End If

            Return Me.RedirectToAction("Index", New With {.Message = AuthorizationService.Controllers.ManageController.ManageMessageId.RemovePhoneSuccess})
        End Function

        '
        ' GET: /Manage/ChangePassword
        Public Function ChangePassword() As ActionResult
            Return Me.View()
        End Function

        '
        ' POST: /Manage/ChangePassword
        <System.Web.Mvc.HttpPostAttribute>
        <System.Web.Mvc.ValidateAntiForgeryTokenAttribute>
        Public Async Function ChangePassword(ByVal model As AuthorizationService.Models.ChangePasswordViewModel) As Task(Of System.Web.Mvc.ActionResult)
            If Not Me.ModelState.IsValid Then
                Return Me.View(model)
            End If

            Dim result = Await Me.UserManager.ChangePasswordAsync(Me.User.Identity.GetUserId(), model.OldPassword, model.NewPassword)
            If result.Succeeded Then
                Dim user = Await Me.UserManager.FindByIdAsync(Me.User.Identity.GetUserId())
                If user IsNot Nothing Then
                    Await Me.SignInManager.SignInAsync(user, isPersistent:=False, rememberBrowser:=False)
                End If

                Return Me.RedirectToAction("Index", New With {.Message = AuthorizationService.Controllers.ManageController.ManageMessageId.ChangePasswordSuccess})
            End If

            Me.AddErrors(result)
            Return Me.View(model)
        End Function

        '
        ' GET: /Manage/SetPassword
        Public Function SetPassword() As ActionResult
            Return Me.View()
        End Function

        '
        ' POST: /Manage/SetPassword
        <System.Web.Mvc.HttpPostAttribute>
        <System.Web.Mvc.ValidateAntiForgeryTokenAttribute>
        Public Async Function SetPassword(ByVal model As AuthorizationService.Models.SetPasswordViewModel) As Task(Of System.Web.Mvc.ActionResult)
            If Me.ModelState.IsValid Then
                Dim result = Await Me.UserManager.AddPasswordAsync(Me.User.Identity.GetUserId(), model.NewPassword)
                If result.Succeeded Then
                    Dim user = Await Me.UserManager.FindByIdAsync(Me.User.Identity.GetUserId())
                    If user IsNot Nothing Then
                        Await Me.SignInManager.SignInAsync(user, isPersistent:=False, rememberBrowser:=False)
                    End If

                    Return Me.RedirectToAction("Index", New With {.Message = AuthorizationService.Controllers.ManageController.ManageMessageId.SetPasswordSuccess})
                End If

                Me.AddErrors(result)
            End If

            ' If we got this far, something failed, redisplay form
            Return Me.View(model)
        End Function

        '
        ' GET: /Manage/ManageLogins
        Public Async Function ManageLogins(ByVal message As AuthorizationService.Controllers.ManageController.ManageMessageId?) As Task(Of System.Web.Mvc.ActionResult)
            Me.ViewData("StatusMessage") = If(message = AuthorizationService.Controllers.ManageController.ManageMessageId.RemoveLoginSuccess, "The external login was removed.", If(message = AuthorizationService.Controllers.ManageController.ManageMessageId.[Error], "An error has occurred.", ""))
            Dim user = Await Me.UserManager.FindByIdAsync(Me.User.Identity.GetUserId())
            If user Is Nothing Then
                Return Me.View("Error")
            End If

            Dim userLogins = Await Me.UserManager.GetLoginsAsync(Me.User.Identity.GetUserId())
            Dim otherLogins = Me.AuthenticationManager.GetExternalAuthenticationTypes().Where(Function(auth) userLogins.All(Function(ul) Not Equals(auth.AuthenticationType, ul.LoginProvider))).ToList()
            Me.ViewData("ShowRemoveButton") = Not Equals(user.PasswordHash, Nothing) OrElse userLogins.Count > 1
            Return Me.View(New AuthorizationService.Models.ManageLoginsViewModel With {.CurrentLogins = userLogins, .OtherLogins = otherLogins})
        End Function

        '
        ' POST: /Manage/LinkLogin
        <System.Web.Mvc.HttpPostAttribute>
        <System.Web.Mvc.ValidateAntiForgeryTokenAttribute>
        Public Function LinkLogin(ByVal provider As String) As ActionResult
            ' Request a redirect to the external login provider to link a login for the current user
            Return New AuthorizationService.Controllers.AccountController.ChallengeResult(provider, Me.Url.Action("LinkLoginCallback", "Manage"), Me.User.Identity.GetUserId())
        End Function

        '
        ' GET: /Manage/LinkLoginCallback
        Public Async Function LinkLoginCallback() As Task(Of System.Web.Mvc.ActionResult)
            Dim loginInfo = Await Me.AuthenticationManager.GetExternalLoginInfoAsync(AuthorizationService.Controllers.ManageController.XsrfKey, Me.User.Identity.GetUserId())
            If loginInfo Is Nothing Then
                Return Me.RedirectToAction("ManageLogins", New With {.Message = AuthorizationService.Controllers.ManageController.ManageMessageId.[Error]})
            End If

            Dim result = Await Me.UserManager.AddLoginAsync(Me.User.Identity.GetUserId(), loginInfo.Login)
            Return If(result.Succeeded, Me.RedirectToAction("ManageLogins"), Me.RedirectToAction("ManageLogins", New With {.Message = AuthorizationService.Controllers.ManageController.ManageMessageId.[Error]}))
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Me._userManager IsNot Nothing Then
                Me._userManager.Dispose()
                Me._userManager = Nothing
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Helpers"
        ' Used for XSRF protection when adding external logins
        Private Const XsrfKey As String = "XsrfId"

        Private ReadOnly Property AuthenticationManager As IAuthenticationManager
            Get
                Return System.Web.HttpContextBaseExtensions.GetOwinContext(Me.HttpContext).Authentication
            End Get
        End Property

        Private Sub AddErrors(ByVal result As Microsoft.AspNet.Identity.IdentityResult)
            For Each [error] In result.Errors
                Me.ModelState.AddModelError("", [error])
            Next
        End Sub

        Private Function HasPassword() As Boolean
            Dim user = Me.UserManager.FindById(Me.User.Identity.GetUserId())
            If user IsNot Nothing Then
                Return Not Equals(user.PasswordHash, Nothing)
            End If

            Return False
        End Function

        Private Function HasPhoneNumber() As Boolean
            Dim user = Me.UserManager.FindById(Me.User.Identity.GetUserId())
            If user IsNot Nothing Then
                Return Not Equals(user.PhoneNumber, Nothing)
            End If

            Return False
        End Function

        Public Enum ManageMessageId
            AddPhoneSuccess
            ChangePasswordSuccess
            SetTwoFactorSuccess
            SetPasswordSuccess
            RemoveLoginSuccess
            RemovePhoneSuccess
            [Error]
        End Enum
#End Region
    End Class
End Namespace
