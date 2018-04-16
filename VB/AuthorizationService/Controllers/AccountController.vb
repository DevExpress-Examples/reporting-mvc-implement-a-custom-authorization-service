Imports System
Imports System.Globalization
Imports System.Linq
Imports System.Security.Claims
Imports System.Threading.Tasks
Imports System.Web
Imports System.Web.Mvc
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin.Security
Imports AuthorizationService.Models

Namespace AuthorizationService.Controllers
    <Authorize> _
    Public Class AccountController
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
        ' GET: /Account/Login
        <AllowAnonymous> _
        Public Function Login(ByVal returnUrl As String) As ActionResult
            ViewData("ReturnUrl") = returnUrl
            Return View()
        End Function

        '
        ' POST: /Account/Login
        <HttpPost, AllowAnonymous, ValidateAntiForgeryToken> _
        Public Async Function Login(ByVal model As LoginViewModel, ByVal returnUrl As String) As Task(Of ActionResult)
            If Not ModelState.IsValid Then
                Return View(model)
            End If

            ' This doesn't count login failures towards account lockout
            ' To enable password failures to trigger account lockout, change to shouldLockout: true
            Dim result = Await SignInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, shouldLockout:= False)
            Select Case result
                Case SignInStatus.Success
                    Return RedirectToLocal(returnUrl)
                Case SignInStatus.LockedOut
                    Return View("Lockout")
                Case SignInStatus.RequiresVerification
                    Return RedirectToAction("SendCode", New With {Key .ReturnUrl = returnUrl, Key .RememberMe = model.RememberMe})
                Case Else
                    ModelState.AddModelError("", "Invalid login attempt.")
                    Return View(model)
            End Select
        End Function

        '
        ' GET: /Account/VerifyCode
        <AllowAnonymous> _
        Public Async Function VerifyCode(ByVal provider As String, ByVal returnUrl As String, ByVal rememberMe As Boolean) As Task(Of ActionResult)
            ' Require that the user has already logged in via username/password or external login
            If Not(Await SignInManager.HasBeenVerifiedAsync()) Then
                Return View("Error")
            End If
            Return View(New VerifyCodeViewModel With {.Provider = provider, .ReturnUrl = returnUrl, .RememberMe = rememberMe})
        End Function

        '
        ' POST: /Account/VerifyCode
        <HttpPost, AllowAnonymous, ValidateAntiForgeryToken> _
        Public Async Function VerifyCode(ByVal model As VerifyCodeViewModel) As Task(Of ActionResult)
            If Not ModelState.IsValid Then
                Return View(model)
            End If

            ' The following code protects for brute force attacks against the two factor codes. 
            ' If a user enters incorrect codes for a specified amount of time then the user account 
            ' will be locked out for a specified amount of time. 
            ' You can configure the account lockout settings in IdentityConfig
            Dim result = Await SignInManager.TwoFactorSignInAsync(model.Provider, model.Code, isPersistent:= model.RememberMe, rememberBrowser:= model.RememberBrowser)
            Select Case result
                Case SignInStatus.Success
                    Return RedirectToLocal(model.ReturnUrl)
                Case SignInStatus.LockedOut
                    Return View("Lockout")
                Case Else
                    ModelState.AddModelError("", "Invalid code.")
                    Return View(model)
            End Select
        End Function

        '
        ' GET: /Account/Register
        <AllowAnonymous> _
        Public Function Register() As ActionResult
            Return View()
        End Function

        '
        ' POST: /Account/Register
        <HttpPost, AllowAnonymous, ValidateAntiForgeryToken> _
        Public Async Function Register(ByVal model As RegisterViewModel) As Task(Of ActionResult)
            If ModelState.IsValid Then

                Dim user_Renamed = New ApplicationUser With {.UserName = model.Email, .Email = model.Email}
                Dim result = Await UserManager.CreateAsync(user_Renamed, model.Password)
                If result.Succeeded Then
                    Await SignInManager.SignInAsync(user_Renamed, isPersistent:=False, rememberBrowser:=False)

                    ' For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                    ' Send an email with this link
                    ' string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                    ' var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                    ' await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");

                    Return RedirectToAction("Index", "Home")
                End If
                AddErrors(result)
            End If

            ' If we got this far, something failed, redisplay form
            Return View(model)
        End Function

        '
        ' GET: /Account/ConfirmEmail
        <AllowAnonymous> _
        Public Async Function ConfirmEmail(ByVal userId As String, ByVal code As String) As Task(Of ActionResult)
            If userId Is Nothing OrElse code Is Nothing Then
                Return View("Error")
            End If
            Dim result = Await UserManager.ConfirmEmailAsync(userId, code)
            Return View(If(result.Succeeded, "ConfirmEmail", "Error"))
        End Function

        '
        ' GET: /Account/ForgotPassword
        <AllowAnonymous> _
        Public Function ForgotPassword() As ActionResult
            Return View()
        End Function

        '
        ' POST: /Account/ForgotPassword
        <HttpPost, AllowAnonymous, ValidateAntiForgeryToken> _
        Public Async Function ForgotPassword(ByVal model As ForgotPasswordViewModel) As Task(Of ActionResult)
            If ModelState.IsValid Then

                Dim user_Renamed = Await UserManager.FindByNameAsync(model.Email)
                If user_Renamed Is Nothing OrElse Not(Await UserManager.IsEmailConfirmedAsync(user_Renamed.Id)) Then
                    ' Don't reveal that the user does not exist or is not confirmed
                    Return View("ForgotPasswordConfirmation")
                End If

                ' For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                ' Send an email with this link
                ' string code = await UserManager.GeneratePasswordResetTokenAsync(user.Id);
                ' var callbackUrl = Url.Action("ResetPassword", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);		
                ' await UserManager.SendEmailAsync(user.Id, "Reset Password", "Please reset your password by clicking <a href=\"" + callbackUrl + "\">here</a>");
                ' return RedirectToAction("ForgotPasswordConfirmation", "Account");
            End If

            ' If we got this far, something failed, redisplay form
            Return View(model)
        End Function

        '
        ' GET: /Account/ForgotPasswordConfirmation
        <AllowAnonymous> _
        Public Function ForgotPasswordConfirmation() As ActionResult
            Return View()
        End Function

        '
        ' GET: /Account/ResetPassword
        <AllowAnonymous> _
        Public Function ResetPassword(ByVal code As String) As ActionResult
            Return If(code Is Nothing, View("Error"), View())
        End Function

        '
        ' POST: /Account/ResetPassword
        <HttpPost, AllowAnonymous, ValidateAntiForgeryToken> _
        Public Async Function ResetPassword(ByVal model As ResetPasswordViewModel) As Task(Of ActionResult)
            If Not ModelState.IsValid Then
                Return View(model)
            End If

            Dim user_Renamed = Await UserManager.FindByNameAsync(model.Email)
            If user_Renamed Is Nothing Then
                ' Don't reveal that the user does not exist
                Return RedirectToAction("ResetPasswordConfirmation", "Account")
            End If
            Dim result = Await UserManager.ResetPasswordAsync(user_Renamed.Id, model.Code, model.Password)
            If result.Succeeded Then
                Return RedirectToAction("ResetPasswordConfirmation", "Account")
            End If
            AddErrors(result)
            Return View()
        End Function

        '
        ' GET: /Account/ResetPasswordConfirmation
        <AllowAnonymous> _
        Public Function ResetPasswordConfirmation() As ActionResult
            Return View()
        End Function

        '
        ' POST: /Account/ExternalLogin
        <HttpPost, AllowAnonymous, ValidateAntiForgeryToken> _
        Public Function ExternalLogin(ByVal provider As String, ByVal returnUrl As String) As ActionResult
            ' Request a redirect to the external login provider
            Return New ChallengeResult(provider, Url.Action("ExternalLoginCallback", "Account", New With {Key .ReturnUrl = returnUrl}))
        End Function

        '
        ' GET: /Account/SendCode
        <AllowAnonymous> _
        Public Async Function SendCode(ByVal returnUrl As String, ByVal rememberMe As Boolean) As Task(Of ActionResult)
            Dim userId = Await SignInManager.GetVerifiedUserIdAsync()
            If userId Is Nothing Then
                Return View("Error")
            End If
            Dim userFactors = Await UserManager.GetValidTwoFactorProvidersAsync(userId)
            Dim factorOptions = userFactors.Select(Function(purpose) New SelectListItem With {.Text = purpose, .Value = purpose}).ToList()
            Return View(New SendCodeViewModel With {.Providers = factorOptions, .ReturnUrl = returnUrl, .RememberMe = rememberMe})
        End Function

        '
        ' POST: /Account/SendCode
        <HttpPost, AllowAnonymous, ValidateAntiForgeryToken> _
        Public Async Function SendCode(ByVal model As SendCodeViewModel) As Task(Of ActionResult)
            If Not ModelState.IsValid Then
                Return View()
            End If

            ' Generate the token and send it
            If Not(Await SignInManager.SendTwoFactorCodeAsync(model.SelectedProvider)) Then
                Return View("Error")
            End If
            Return RedirectToAction("VerifyCode", New With {Key .Provider = model.SelectedProvider, Key .ReturnUrl = model.ReturnUrl, Key .RememberMe = model.RememberMe})
        End Function

        '
        ' GET: /Account/ExternalLoginCallback
        <AllowAnonymous> _
        Public Async Function ExternalLoginCallback(ByVal returnUrl As String) As Task(Of ActionResult)
            Dim loginInfo = Await AuthenticationManager.GetExternalLoginInfoAsync()
            If loginInfo Is Nothing Then
                Return RedirectToAction("Login")
            End If

            ' Sign in the user with this external login provider if the user already has a login
            Dim result = Await SignInManager.ExternalSignInAsync(loginInfo, isPersistent:= False)
            Select Case result
                Case SignInStatus.Success
                    Return RedirectToLocal(returnUrl)
                Case SignInStatus.LockedOut
                    Return View("Lockout")
                Case SignInStatus.RequiresVerification
                    Return RedirectToAction("SendCode", New With {Key .ReturnUrl = returnUrl, Key .RememberMe = False})
                Case Else
                    ' If the user does not have an account, then prompt the user to create an account
                    ViewData("ReturnUrl") = returnUrl
                    ViewData("LoginProvider") = loginInfo.Login.LoginProvider
                    Return View("ExternalLoginConfirmation", New ExternalLoginConfirmationViewModel With {.Email = loginInfo.Email})
            End Select
        End Function

        '
        ' POST: /Account/ExternalLoginConfirmation
        <HttpPost, AllowAnonymous, ValidateAntiForgeryToken> _
        Public Async Function ExternalLoginConfirmation(ByVal model As ExternalLoginConfirmationViewModel, ByVal returnUrl As String) As Task(Of ActionResult)
            If User.Identity.IsAuthenticated Then
                Return RedirectToAction("Index", "Manage")
            End If

            If ModelState.IsValid Then
                ' Get the information about the user from the external login provider
                Dim info = Await AuthenticationManager.GetExternalLoginInfoAsync()
                If info Is Nothing Then
                    Return View("ExternalLoginFailure")
                End If

                Dim user_Renamed = New ApplicationUser With {.UserName = model.Email, .Email = model.Email}
                Dim result = Await UserManager.CreateAsync(user_Renamed)
                If result.Succeeded Then
                    result = Await UserManager.AddLoginAsync(user_Renamed.Id, info.Login)
                    If result.Succeeded Then
                        Await SignInManager.SignInAsync(user_Renamed, isPersistent:= False, rememberBrowser:= False)
                        Return RedirectToLocal(returnUrl)
                    End If
                End If
                AddErrors(result)
            End If

            ViewData("ReturnUrl") = returnUrl
            Return View(model)
        End Function

        '
        ' POST: /Account/LogOff
        <HttpPost, ValidateAntiForgeryToken> _
        Public Function LogOff() As ActionResult
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie)
            Return RedirectToAction("Index", "Home")
        End Function

        '
        ' GET: /Account/ExternalLoginFailure
        <AllowAnonymous> _
        Public Function ExternalLoginFailure() As ActionResult
            Return View()
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If _userManager IsNot Nothing Then
                    _userManager.Dispose()
                    _userManager = Nothing
                End If

                If _signInManager IsNot Nothing Then
                    _signInManager.Dispose()
                    _signInManager = Nothing
                End If
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

        Private Function RedirectToLocal(ByVal returnUrl As String) As ActionResult
            If Url.IsLocalUrl(returnUrl) Then
                Return Redirect(returnUrl)
            End If
            Return RedirectToAction("Index", "Home")
        End Function

        Friend Class ChallengeResult
            Inherits HttpUnauthorizedResult

            Public Sub New(ByVal provider As String, ByVal redirectUri As String)
                Me.New(provider, redirectUri, Nothing)
            End Sub

            Public Sub New(ByVal provider As String, ByVal redirectUri As String, ByVal userId As String)
                LoginProvider = provider
                Me.RedirectUri = redirectUri
                Me.UserId = userId
            End Sub

            Public Property LoginProvider() As String
            Public Property RedirectUri() As String
            Public Property UserId() As String

            Public Overrides Sub ExecuteResult(ByVal context As ControllerContext)
                Dim properties = New AuthenticationProperties With {.RedirectUri = RedirectUri}
                If UserId IsNot Nothing Then
                    properties.Dictionary(XsrfKey) = UserId
                End If
                context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider)
            End Sub
        End Class
        #End Region
    End Class
End Namespace