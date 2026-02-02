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

    <System.Web.Mvc.AuthorizeAttribute>
    Public Class AccountController
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
        ' GET: /Account/Login
        <System.Web.Mvc.AllowAnonymousAttribute>
        Public Function Login(ByVal returnUrl As String) As ActionResult
            Me.ViewData("ReturnUrl") = returnUrl
            Return Me.View()
        End Function

        '
        ' POST: /Account/Login
        <System.Web.Mvc.HttpPostAttribute>
        <System.Web.Mvc.AllowAnonymousAttribute>
        <System.Web.Mvc.ValidateAntiForgeryTokenAttribute>
        Public Async Function Login(ByVal model As AuthorizationService.Models.LoginViewModel, ByVal returnUrl As String) As Task(Of System.Web.Mvc.ActionResult)
            If Not Me.ModelState.IsValid Then
                Return Me.View(model)
            End If

            ' This doesn't count login failures towards account lockout
            ' To enable password failures to trigger account lockout, change to shouldLockout: true
            Dim result = Await Me.SignInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, shouldLockout:=False)
            Select Case result
                Case Microsoft.AspNet.Identity.Owin.SignInStatus.Success
                    Return Me.RedirectToLocal(returnUrl)
                Case Microsoft.AspNet.Identity.Owin.SignInStatus.LockedOut
                    Return Me.View("Lockout")
                Case Microsoft.AspNet.Identity.Owin.SignInStatus.RequiresVerification
                    Return Me.RedirectToAction("SendCode", New With {.ReturnUrl = returnUrl, .RememberMe = model.RememberMe})
                Case Else
                    Me.ModelState.AddModelError("", "Invalid login attempt.")
                    Return Me.View(model)
            End Select
        End Function

        '
        ' GET: /Account/VerifyCode
        <System.Web.Mvc.AllowAnonymousAttribute>
        Public Async Function VerifyCode(ByVal provider As String, ByVal returnUrl As String, ByVal rememberMe As Boolean) As Task(Of System.Web.Mvc.ActionResult)
            ' Require that the user has already logged in via username/password or external login
            If Not(Await Me.SignInManager.HasBeenVerifiedAsync()) Then
                Return Me.View("Error")
            End If

            Return Me.View(New AuthorizationService.Models.VerifyCodeViewModel With {.Provider = provider, .ReturnUrl = returnUrl, .RememberMe = rememberMe})
        End Function

        '
        ' POST: /Account/VerifyCode
        <System.Web.Mvc.HttpPostAttribute>
        <System.Web.Mvc.AllowAnonymousAttribute>
        <System.Web.Mvc.ValidateAntiForgeryTokenAttribute>
        Public Async Function VerifyCode(ByVal model As AuthorizationService.Models.VerifyCodeViewModel) As Task(Of System.Web.Mvc.ActionResult)
            If Not Me.ModelState.IsValid Then
                Return Me.View(model)
            End If

            ' The following code protects for brute force attacks against the two factor codes. 
            ' If a user enters incorrect codes for a specified amount of time then the user account 
            ' will be locked out for a specified amount of time. 
            ' You can configure the account lockout settings in IdentityConfig
            Dim result = Await Me.SignInManager.TwoFactorSignInAsync(model.Provider, model.Code, isPersistent:=model.RememberMe, rememberBrowser:=model.RememberBrowser)
            Select Case result
                Case Microsoft.AspNet.Identity.Owin.SignInStatus.Success
                    Return Me.RedirectToLocal(model.ReturnUrl)
                Case Microsoft.AspNet.Identity.Owin.SignInStatus.LockedOut
                    Return Me.View("Lockout")
                Case Else
                    Me.ModelState.AddModelError("", "Invalid code.")
                    Return Me.View(model)
            End Select
        End Function

        '
        ' GET: /Account/Register
        <System.Web.Mvc.AllowAnonymousAttribute>
        Public Function Register() As ActionResult
            Return Me.View()
        End Function

        '
        ' POST: /Account/Register
        <System.Web.Mvc.HttpPostAttribute>
        <System.Web.Mvc.AllowAnonymousAttribute>
        <System.Web.Mvc.ValidateAntiForgeryTokenAttribute>
        Public Async Function Register(ByVal model As AuthorizationService.Models.RegisterViewModel) As Task(Of System.Web.Mvc.ActionResult)
            If Me.ModelState.IsValid Then
                Dim user = New AuthorizationService.Models.ApplicationUser With {.UserName = model.Email, .Email = model.Email}
                Dim result = Await Me.UserManager.CreateAsync(user, model.Password)
                If result.Succeeded Then
                    Await Me.SignInManager.SignInAsync(user, isPersistent:=False, rememberBrowser:=False)
                    ' For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                    ' Send an email with this link
                    ' string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                    ' var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                    ' await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");
                    Return Me.RedirectToAction("Index", "Home")
                End If

                Me.AddErrors(result)
            End If

            ' If we got this far, something failed, redisplay form
            Return Me.View(model)
        End Function

        '
        ' GET: /Account/ConfirmEmail
        <System.Web.Mvc.AllowAnonymousAttribute>
        Public Async Function ConfirmEmail(ByVal userId As String, ByVal code As String) As Task(Of System.Web.Mvc.ActionResult)
            If Equals(userId, Nothing) OrElse Equals(code, Nothing) Then
                Return Me.View("Error")
            End If

            Dim result = Await Me.UserManager.ConfirmEmailAsync(userId, code)
            Return Me.View(If(result.Succeeded, "ConfirmEmail", "Error"))
        End Function

        '
        ' GET: /Account/ForgotPassword
        <System.Web.Mvc.AllowAnonymousAttribute>
        Public Function ForgotPassword() As ActionResult
            Return Me.View()
        End Function

        '
        ' POST: /Account/ForgotPassword
        <System.Web.Mvc.HttpPostAttribute>
        <System.Web.Mvc.AllowAnonymousAttribute>
        <System.Web.Mvc.ValidateAntiForgeryTokenAttribute>
        Public Async Function ForgotPassword(ByVal model As AuthorizationService.Models.ForgotPasswordViewModel) As Task(Of System.Web.Mvc.ActionResult)
            If Me.ModelState.IsValid Then
                Dim user = Await Me.UserManager.FindByNameAsync(model.Email)
                If user Is Nothing OrElse Not(Await Me.UserManager.IsEmailConfirmedAsync(user.Id)) Then
                    ' Don't reveal that the user does not exist or is not confirmed
                    Return Me.View("ForgotPasswordConfirmation")
                End If
            ' For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
            ' Send an email with this link
            ' string code = await UserManager.GeneratePasswordResetTokenAsync(user.Id);
            ' var callbackUrl = Url.Action("ResetPassword", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);		
            ' await UserManager.SendEmailAsync(user.Id, "Reset Password", "Please reset your password by clicking <a href=\"" + callbackUrl + "\">here</a>");
            ' return RedirectToAction("ForgotPasswordConfirmation", "Account");
            End If

            ' If we got this far, something failed, redisplay form
            Return Me.View(model)
        End Function

        '
        ' GET: /Account/ForgotPasswordConfirmation
        <System.Web.Mvc.AllowAnonymousAttribute>
        Public Function ForgotPasswordConfirmation() As ActionResult
            Return Me.View()
        End Function

        '
        ' GET: /Account/ResetPassword
        <System.Web.Mvc.AllowAnonymousAttribute>
        Public Function ResetPassword(ByVal code As String) As ActionResult
            Return If(Equals(code, Nothing), Me.View("Error"), Me.View())
        End Function

        '
        ' POST: /Account/ResetPassword
        <System.Web.Mvc.HttpPostAttribute>
        <System.Web.Mvc.AllowAnonymousAttribute>
        <System.Web.Mvc.ValidateAntiForgeryTokenAttribute>
        Public Async Function ResetPassword(ByVal model As AuthorizationService.Models.ResetPasswordViewModel) As Task(Of System.Web.Mvc.ActionResult)
            If Not Me.ModelState.IsValid Then
                Return Me.View(model)
            End If

            Dim user = Await Me.UserManager.FindByNameAsync(model.Email)
            If user Is Nothing Then
                ' Don't reveal that the user does not exist
                Return Me.RedirectToAction("ResetPasswordConfirmation", "Account")
            End If

            Dim result = Await Me.UserManager.ResetPasswordAsync(user.Id, model.Code, model.Password)
            If result.Succeeded Then
                Return Me.RedirectToAction("ResetPasswordConfirmation", "Account")
            End If

            Me.AddErrors(result)
            Return Me.View()
        End Function

        '
        ' GET: /Account/ResetPasswordConfirmation
        <System.Web.Mvc.AllowAnonymousAttribute>
        Public Function ResetPasswordConfirmation() As ActionResult
            Return Me.View()
        End Function

        '
        ' POST: /Account/ExternalLogin
        <System.Web.Mvc.HttpPostAttribute>
        <System.Web.Mvc.AllowAnonymousAttribute>
        <System.Web.Mvc.ValidateAntiForgeryTokenAttribute>
        Public Function ExternalLogin(ByVal provider As String, ByVal returnUrl As String) As ActionResult
            ' Request a redirect to the external login provider
            Return New AuthorizationService.Controllers.AccountController.ChallengeResult(provider, Me.Url.Action("ExternalLoginCallback", "Account", New With {.ReturnUrl = returnUrl}))
        End Function

        '
        ' GET: /Account/SendCode
        <System.Web.Mvc.AllowAnonymousAttribute>
        Public Async Function SendCode(ByVal returnUrl As String, ByVal rememberMe As Boolean) As Task(Of System.Web.Mvc.ActionResult)
            Dim userId = Await Me.SignInManager.GetVerifiedUserIdAsync()
            If Equals(userId, Nothing) Then
                Return Me.View("Error")
            End If

            Dim userFactors = Await Me.UserManager.GetValidTwoFactorProvidersAsync(userId)
            Dim factorOptions = userFactors.[Select](Function(purpose) New System.Web.Mvc.SelectListItem With {.Text = purpose, .Value = purpose}).ToList()
            Return Me.View(New AuthorizationService.Models.SendCodeViewModel With {.Providers = factorOptions, .ReturnUrl = returnUrl, .RememberMe = rememberMe})
        End Function

        '
        ' POST: /Account/SendCode
        <System.Web.Mvc.HttpPostAttribute>
        <System.Web.Mvc.AllowAnonymousAttribute>
        <System.Web.Mvc.ValidateAntiForgeryTokenAttribute>
        Public Async Function SendCode(ByVal model As AuthorizationService.Models.SendCodeViewModel) As Task(Of System.Web.Mvc.ActionResult)
            If Not Me.ModelState.IsValid Then
                Return Me.View()
            End If

            ' Generate the token and send it
            If Not(Await Me.SignInManager.SendTwoFactorCodeAsync(model.SelectedProvider)) Then
                Return Me.View("Error")
            End If

            Return Me.RedirectToAction("VerifyCode", New With {.Provider = model.SelectedProvider, .ReturnUrl = model.ReturnUrl, .RememberMe = model.RememberMe})
        End Function

        '
        ' GET: /Account/ExternalLoginCallback
        <System.Web.Mvc.AllowAnonymousAttribute>
        Public Async Function ExternalLoginCallback(ByVal returnUrl As String) As Task(Of System.Web.Mvc.ActionResult)
            Dim loginInfo = Await Me.AuthenticationManager.GetExternalLoginInfoAsync()
            If loginInfo Is Nothing Then
                Return Me.RedirectToAction("Login")
            End If

            ' Sign in the user with this external login provider if the user already has a login
            Dim result = Await Me.SignInManager.ExternalSignInAsync(loginInfo, isPersistent:=False)
            Select Case result
                Case Microsoft.AspNet.Identity.Owin.SignInStatus.Success
                    Return Me.RedirectToLocal(returnUrl)
                Case Microsoft.AspNet.Identity.Owin.SignInStatus.LockedOut
                    Return Me.View("Lockout")
                Case Microsoft.AspNet.Identity.Owin.SignInStatus.RequiresVerification
                    Return Me.RedirectToAction("SendCode", New With {.ReturnUrl = returnUrl, .RememberMe = False})
                Case Else
                    ' If the user does not have an account, then prompt the user to create an account
                    Me.ViewData("ReturnUrl") = returnUrl
                    Me.ViewData("LoginProvider") = loginInfo.Login.LoginProvider
                    Return Me.View("ExternalLoginConfirmation", New AuthorizationService.Models.ExternalLoginConfirmationViewModel With {.Email = loginInfo.Email})
            End Select
        End Function

        '
        ' POST: /Account/ExternalLoginConfirmation
        <System.Web.Mvc.HttpPostAttribute>
        <System.Web.Mvc.AllowAnonymousAttribute>
        <System.Web.Mvc.ValidateAntiForgeryTokenAttribute>
        Public Async Function ExternalLoginConfirmation(ByVal model As AuthorizationService.Models.ExternalLoginConfirmationViewModel, ByVal returnUrl As String) As Task(Of System.Web.Mvc.ActionResult)
            If Me.User.Identity.IsAuthenticated Then
                Return Me.RedirectToAction("Index", "Manage")
            End If

            If Me.ModelState.IsValid Then
                ' Get the information about the user from the external login provider
                Dim info = Await Me.AuthenticationManager.GetExternalLoginInfoAsync()
                If info Is Nothing Then
                    Return Me.View("ExternalLoginFailure")
                End If

                Dim user = New AuthorizationService.Models.ApplicationUser With {.UserName = model.Email, .Email = model.Email}
                Dim result = Await Me.UserManager.CreateAsync(user)
                If result.Succeeded Then
                    result = Await Me.UserManager.AddLoginAsync(user.Id, info.Login)
                    If result.Succeeded Then
                        Await Me.SignInManager.SignInAsync(user, isPersistent:=False, rememberBrowser:=False)
                        Return Me.RedirectToLocal(returnUrl)
                    End If
                End If

                Me.AddErrors(result)
            End If

            Me.ViewData("ReturnUrl") = returnUrl
            Return Me.View(model)
        End Function

        '
        ' POST: /Account/LogOff
        <System.Web.Mvc.HttpPostAttribute>
        <System.Web.Mvc.ValidateAntiForgeryTokenAttribute>
        Public Function LogOff() As ActionResult
            Me.AuthenticationManager.SignOut(Microsoft.AspNet.Identity.DefaultAuthenticationTypes.ApplicationCookie)
            Return Me.RedirectToAction("Index", "Home")
        End Function

        '
        ' GET: /Account/ExternalLoginFailure
        <System.Web.Mvc.AllowAnonymousAttribute>
        Public Function ExternalLoginFailure() As ActionResult
            Return Me.View()
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me._userManager IsNot Nothing Then
                    Me._userManager.Dispose()
                    Me._userManager = Nothing
                End If

                If Me._signInManager IsNot Nothing Then
                    Me._signInManager.Dispose()
                    Me._signInManager = Nothing
                End If
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

        Private Function RedirectToLocal(ByVal returnUrl As String) As ActionResult
            If Me.Url.IsLocalUrl(returnUrl) Then
                Return Me.Redirect(returnUrl)
            End If

            Return Me.RedirectToAction("Index", "Home")
        End Function

        Friend Class ChallengeResult
            Inherits System.Web.Mvc.HttpUnauthorizedResult

            Public Sub New(ByVal provider As String, ByVal redirectUri As String)
                Me.New(provider, redirectUri, Nothing)
            End Sub

            Public Sub New(ByVal provider As String, ByVal redirectUri As String, ByVal userId As String)
                Me.LoginProvider = provider
                Me.RedirectUri = redirectUri
                Me.UserId = userId
            End Sub

            Public Property LoginProvider As String

            Public Property RedirectUri As String

            Public Property UserId As String

            Public Overrides Sub ExecuteResult(ByVal context As System.Web.Mvc.ControllerContext)
                Dim properties = New Microsoft.Owin.Security.AuthenticationProperties With {.RedirectUri = Me.RedirectUri}
                If Not Equals(Me.UserId, Nothing) Then
                    properties.Dictionary(AuthorizationService.Controllers.AccountController.XsrfKey) = Me.UserId
                End If

                System.Web.HttpContextBaseExtensions.GetOwinContext(context.HttpContext).Authentication.Challenge(properties, Me.LoginProvider)
            End Sub
        End Class
#End Region
    End Class
End Namespace
