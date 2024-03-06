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
    <Authorize> _
    Public Class ManageController
        Inherits Controller

        Private _signInManager As ApplicationSignInManager
        Private _userManager As ApplicationUserManager

        Public Sub New()
        End Sub

        Public Sub New(ByVal userManager As ApplicationUserManager, ByVal signInManager As ApplicationSignInManager)
            Me.UserManager = userManager
            Me.SignInManager = signInManager
        End Sub

        Public Property SignInManager() As ApplicationSignInManager
            Get
                Return If(_signInManager Is Nothing, HttpContext.GetOwinContext().Get(Of ApplicationSignInManager)(), _signInManager)
            End Get
            Private Set(ByVal value As ApplicationSignInManager)
                _signInManager = value
            End Set
        End Property

        Public Property UserManager() As ApplicationUserManager
            Get
                Return If(_userManager Is Nothing, HttpContext.GetOwinContext().GetUserManager(Of ApplicationUserManager)(), _userManager)
            End Get
            Private Set(ByVal value As ApplicationUserManager)
                _userManager = value
            End Set
        End Property

        '
        ' GET: /Manage/Index
        Public Async Function Index(ByVal message? As ManageMessageId) As Task(Of ActionResult)
            ViewData("StatusMessage") = If(message.Equals(ManageMessageId.ChangePasswordSuccess), "Your password has been changed.", If(message.Equals(ManageMessageId.SetPasswordSuccess), "Your password has been set.", If(message.Equals(ManageMessageId.SetTwoFactorSuccess), "Your two-factor authentication provider has been set.", If(message.Equals(ManageMessageId.Error), "An error has occurred.", If(message.Equals(ManageMessageId.AddPhoneSuccess), "Your phone number was added.", If(message.Equals(ManageMessageId.RemovePhoneSuccess), "Your phone number was removed.", ""))))))

            Dim userId = User.Identity.GetUserId()
            Dim model = New IndexViewModel With { _
                .HasPassword = HasPassword(), _
                .PhoneNumber = Await UserManager.GetPhoneNumberAsync(userId), _
                .TwoFactor = Await UserManager.GetTwoFactorEnabledAsync(userId), _
                .Logins = Await UserManager.GetLoginsAsync(userId), _
                .BrowserRemembered = Await AuthenticationManager.TwoFactorBrowserRememberedAsync(userId) _
            }
            Return View(model)
        End Function

        '
        ' POST: /Manage/RemoveLogin
        <HttpPost, ValidateAntiForgeryToken> _
        Public Async Function RemoveLogin(ByVal loginProvider As String, ByVal providerKey As String) As Task(Of ActionResult)
            Dim message? As ManageMessageId
            Dim result = Await UserManager.RemoveLoginAsync(User.Identity.GetUserId(), New UserLoginInfo(loginProvider, providerKey))
            If result.Succeeded Then

                Dim user_Renamed = Await UserManager.FindByIdAsync(User.Identity.GetUserId())
                If user_Renamed IsNot Nothing Then
                    Await SignInManager.SignInAsync(user_Renamed, isPersistent:= False, rememberBrowser:= False)
                End If
                message = ManageMessageId.RemoveLoginSuccess
            Else
                message = ManageMessageId.Error
            End If
            Return RedirectToAction("ManageLogins", New With {Key .Message = message})
        End Function

        '
        ' GET: /Manage/AddPhoneNumber
        Public Function AddPhoneNumber() As ActionResult
            Return View()
        End Function

        '
        ' POST: /Manage/AddPhoneNumber
        <HttpPost, ValidateAntiForgeryToken> _
        Public Async Function AddPhoneNumber(ByVal model As AddPhoneNumberViewModel) As Task(Of ActionResult)
            If Not ModelState.IsValid Then
                Return View(model)
            End If
            ' Generate the token and send it
            Dim code = Await UserManager.GenerateChangePhoneNumberTokenAsync(User.Identity.GetUserId(), model.Number)
            If UserManager.SmsService IsNot Nothing Then
                Dim message = New IdentityMessage With { _
                    .Destination = model.Number, _
                    .Body = "Your security code is: " & code _
                }
                Await UserManager.SmsService.SendAsync(message)
            End If
            Return RedirectToAction("VerifyPhoneNumber", New With {Key .PhoneNumber = model.Number})
        End Function

        '
        ' POST: /Manage/EnableTwoFactorAuthentication
        <HttpPost, ValidateAntiForgeryToken> _
        Public Async Function EnableTwoFactorAuthentication() As Task(Of ActionResult)
            Await UserManager.SetTwoFactorEnabledAsync(User.Identity.GetUserId(), True)

            Dim user_Renamed = Await UserManager.FindByIdAsync(User.Identity.GetUserId())
            If user_Renamed IsNot Nothing Then
                Await SignInManager.SignInAsync(user_Renamed, isPersistent:= False, rememberBrowser:= False)
            End If
            Return RedirectToAction("Index", "Manage")
        End Function

        '
        ' POST: /Manage/DisableTwoFactorAuthentication
        <HttpPost, ValidateAntiForgeryToken> _
        Public Async Function DisableTwoFactorAuthentication() As Task(Of ActionResult)
            Await UserManager.SetTwoFactorEnabledAsync(User.Identity.GetUserId(), False)

            Dim user_Renamed = Await UserManager.FindByIdAsync(User.Identity.GetUserId())
            If user_Renamed IsNot Nothing Then
                Await SignInManager.SignInAsync(user_Renamed, isPersistent:= False, rememberBrowser:= False)
            End If
            Return RedirectToAction("Index", "Manage")
        End Function

        '
        ' GET: /Manage/VerifyPhoneNumber
        Public Async Function VerifyPhoneNumber(ByVal phoneNumber As String) As Task(Of ActionResult)
            Dim code = Await UserManager.GenerateChangePhoneNumberTokenAsync(User.Identity.GetUserId(), phoneNumber)
            ' Send an SMS through the SMS provider to verify the phone number
            Return If(phoneNumber Is Nothing, View("Error"), View(New VerifyPhoneNumberViewModel With {.PhoneNumber = phoneNumber}))
        End Function

        '
        ' POST: /Manage/VerifyPhoneNumber
        <HttpPost, ValidateAntiForgeryToken> _
        Public Async Function VerifyPhoneNumber(ByVal model As VerifyPhoneNumberViewModel) As Task(Of ActionResult)
            If Not ModelState.IsValid Then
                Return View(model)
            End If
            Dim result = Await UserManager.ChangePhoneNumberAsync(User.Identity.GetUserId(), model.PhoneNumber, model.Code)
            If result.Succeeded Then

                Dim user_Renamed = Await UserManager.FindByIdAsync(User.Identity.GetUserId())
                If user_Renamed IsNot Nothing Then
                    Await SignInManager.SignInAsync(user_Renamed, isPersistent:= False, rememberBrowser:= False)
                End If
                Return RedirectToAction("Index", New With {Key .Message = ManageMessageId.AddPhoneSuccess})
            End If
            ' If we got this far, something failed, redisplay form
            ModelState.AddModelError("", "Failed to verify phone")
            Return View(model)
        End Function

        '
        ' GET: /Manage/RemovePhoneNumber
        Public Async Function RemovePhoneNumber() As Task(Of ActionResult)
            Dim result = Await UserManager.SetPhoneNumberAsync(User.Identity.GetUserId(), Nothing)
            If Not result.Succeeded Then
                Return RedirectToAction("Index", New With {Key .Message = ManageMessageId.Error})
            End If

            Dim user_Renamed = Await UserManager.FindByIdAsync(User.Identity.GetUserId())
            If user_Renamed IsNot Nothing Then
                Await SignInManager.SignInAsync(user_Renamed, isPersistent:= False, rememberBrowser:= False)
            End If
            Return RedirectToAction("Index", New With {Key .Message = ManageMessageId.RemovePhoneSuccess})
        End Function

        '
        ' GET: /Manage/ChangePassword
        Public Function ChangePassword() As ActionResult
            Return View()
        End Function

        '
        ' POST: /Manage/ChangePassword
        <HttpPost, ValidateAntiForgeryToken> _
        Public Async Function ChangePassword(ByVal model As ChangePasswordViewModel) As Task(Of ActionResult)
            If Not ModelState.IsValid Then
                Return View(model)
            End If
            Dim result = Await UserManager.ChangePasswordAsync(User.Identity.GetUserId(), model.OldPassword, model.NewPassword)
            If result.Succeeded Then

                Dim user_Renamed = Await UserManager.FindByIdAsync(User.Identity.GetUserId())
                If user_Renamed IsNot Nothing Then
                    Await SignInManager.SignInAsync(user_Renamed, isPersistent:= False, rememberBrowser:= False)
                End If
                Return RedirectToAction("Index", New With {Key .Message = ManageMessageId.ChangePasswordSuccess})
            End If
            AddErrors(result)
            Return View(model)
        End Function

        '
        ' GET: /Manage/SetPassword
        Public Function SetPassword() As ActionResult
            Return View()
        End Function

        '
        ' POST: /Manage/SetPassword
        <HttpPost, ValidateAntiForgeryToken> _
        Public Async Function SetPassword(ByVal model As SetPasswordViewModel) As Task(Of ActionResult)
            If ModelState.IsValid Then
                Dim result = Await UserManager.AddPasswordAsync(User.Identity.GetUserId(), model.NewPassword)
                If result.Succeeded Then

                    Dim user_Renamed = Await UserManager.FindByIdAsync(User.Identity.GetUserId())
                    If user_Renamed IsNot Nothing Then
                        Await SignInManager.SignInAsync(user_Renamed, isPersistent:= False, rememberBrowser:= False)
                    End If
                    Return RedirectToAction("Index", New With {Key .Message = ManageMessageId.SetPasswordSuccess})
                End If
                AddErrors(result)
            End If

            ' If we got this far, something failed, redisplay form
            Return View(model)
        End Function

        '
        ' GET: /Manage/ManageLogins
        Public Async Function ManageLogins(ByVal message? As ManageMessageId) As Task(Of ActionResult)
            ViewData("StatusMessage") = If(message.Equals(ManageMessageId.RemoveLoginSuccess), "The external login was removed.", If(message.Equals(ManageMessageId.Error), "An error has occurred.", ""))

            Dim user_Renamed = Await UserManager.FindByIdAsync(User.Identity.GetUserId())
            If user_Renamed Is Nothing Then
                Return View("Error")
            End If
            Dim userLogins = Await UserManager.GetLoginsAsync(User.Identity.GetUserId())
            Dim otherLogins = AuthenticationManager.GetExternalAuthenticationTypes().Where(Function(auth) userLogins.All(Function(ul) auth.AuthenticationType <> ul.LoginProvider)).ToList()
            ViewData("ShowRemoveButton") = user_Renamed.PasswordHash IsNot Nothing OrElse userLogins.Count > 1
            Return View(New ManageLoginsViewModel With { _
                .CurrentLogins = userLogins, _
                .OtherLogins = otherLogins _
            })
        End Function

        '
        ' POST: /Manage/LinkLogin
        <HttpPost, ValidateAntiForgeryToken> _
        Public Function LinkLogin(ByVal provider As String) As ActionResult
            ' Request a redirect to the external login provider to link a login for the current user
            Return New AccountController.ChallengeResult(provider, Url.Action("LinkLoginCallback", "Manage"), User.Identity.GetUserId())
        End Function

        '
        ' GET: /Manage/LinkLoginCallback
        Public Async Function LinkLoginCallback() As Task(Of ActionResult)
            Dim loginInfo = Await AuthenticationManager.GetExternalLoginInfoAsync(XsrfKey, User.Identity.GetUserId())
            If loginInfo Is Nothing Then
                Return RedirectToAction("ManageLogins", New With {Key .Message = ManageMessageId.Error})
            End If
            Dim result = Await UserManager.AddLoginAsync(User.Identity.GetUserId(), loginInfo.Login)
            Return If(result.Succeeded, RedirectToAction("ManageLogins"), RedirectToAction("ManageLogins", New With {Key .Message = ManageMessageId.Error}))
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso _userManager IsNot Nothing Then
                _userManager.Dispose()
                _userManager = Nothing
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Helpers"
        ' Used for XSRF protection when adding external logins
        Private Const XsrfKey As String = "XsrfId"

        Private ReadOnly Property AuthenticationManager() As IAuthenticationManager
            Get
                Return HttpContext.GetOwinContext().Authentication
            End Get
        End Property

        Private Sub AddErrors(ByVal result As IdentityResult)
            For Each [error] In result.Errors
                ModelState.AddModelError("", [error])
            Next [error]
        End Sub

        Private Function HasPassword() As Boolean

            Dim user_Renamed = UserManager.FindById(User.Identity.GetUserId())
            If user_Renamed IsNot Nothing Then
                Return user_Renamed.PasswordHash IsNot Nothing
            End If
            Return False
        End Function

        Private Function HasPhoneNumber() As Boolean

            Dim user_Renamed = UserManager.FindById(User.Identity.GetUserId())
            If user_Renamed IsNot Nothing Then
                Return user_Renamed.PhoneNumber IsNot Nothing
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
