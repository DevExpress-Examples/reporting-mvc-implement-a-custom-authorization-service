Imports AuthorizationService.Models
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin
Imports Microsoft.Owin.Security
Imports System
Imports System.Security.Claims
Imports System.Threading.Tasks

Namespace AuthorizationService
    Public Class EmailService
        Implements IIdentityMessageService

        Private Function IIdentityMessageService_SendAsync(ByVal message As IdentityMessage) As Task Implements IIdentityMessageService.SendAsync
            ' Plug in your email service here to send an email.
            Return Task.FromResult(0)
        End Function
    End Class

    Public Class SmsService
        Implements IIdentityMessageService

        Private Function IIdentityMessageService_SendAsync(ByVal message As IdentityMessage) As Task Implements IIdentityMessageService.SendAsync
            ' Plug in your SMS service here to send a text message.
            Return Task.FromResult(0)
        End Function
    End Class

    ' Configure the application user manager used in this application. UserManager is defined in ASP.NET Identity and is used by the application.
    Public Class ApplicationUserManager
        Inherits UserManager(Of ApplicationUser)

        Public Sub New(ByVal store As IUserStore(Of ApplicationUser))
            MyBase.New(store)
        End Sub

        Public Shared Function Create(ByVal options As IdentityFactoryOptions(Of ApplicationUserManager), ByVal context As IOwinContext) As ApplicationUserManager
            Dim manager = New ApplicationUserManager(New UserStore(Of ApplicationUser)(context.Get(Of ApplicationDbContext)()))
            ' Configure validation logic for usernames
            manager.UserValidator = New UserValidator(Of ApplicationUser)(manager) With { _
                .AllowOnlyAlphanumericUserNames = False, _
                .RequireUniqueEmail = True _
            }

            ' Configure validation logic for passwords
            manager.PasswordValidator = New PasswordValidator With { _
                .RequiredLength = 6, _
                .RequireNonLetterOrDigit = True, _
                .RequireDigit = True, _
                .RequireLowercase = True, _
                .RequireUppercase = True _
            }

            ' Configure user lockout defaults
            manager.UserLockoutEnabledByDefault = True
            manager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5)
            manager.MaxFailedAccessAttemptsBeforeLockout = 5

            ' Register two factor authentication providers. This application uses Phone and Emails as a step of receiving a code for verifying the user
            ' You can write your own provider and plug it in here.
            manager.RegisterTwoFactorProvider("Phone Code", New PhoneNumberTokenProvider(Of ApplicationUser) With {.MessageFormat = "Your security code is {0}"})
            manager.RegisterTwoFactorProvider("Email Code", New EmailTokenProvider(Of ApplicationUser) With { _
                .Subject = "Security Code", _
                .BodyFormat = "Your security code is {0}" _
            })
            manager.EmailService = New EmailService()
            manager.SmsService = New SmsService()
            Dim dataProtectionProvider = options.DataProtectionProvider
            If dataProtectionProvider IsNot Nothing Then
                manager.UserTokenProvider = New DataProtectorTokenProvider(Of ApplicationUser)(dataProtectionProvider.Create("ASP.NET Identity"))
            End If
            Return manager
        End Function
    End Class

    ' Configure the application sign-in manager which is used in this application.
    Public Class ApplicationSignInManager
        Inherits SignInManager(Of ApplicationUser, String)

        Public Sub New(ByVal userManager As ApplicationUserManager, ByVal authenticationManager As IAuthenticationManager)
            MyBase.New(userManager, authenticationManager)
        End Sub

        Public Overrides Function CreateUserIdentityAsync(ByVal user As ApplicationUser) As Task(Of ClaimsIdentity)
            Return user.GenerateUserIdentityAsync(CType(UserManager, ApplicationUserManager))
        End Function

        Public Shared Function Create(ByVal options As IdentityFactoryOptions(Of ApplicationSignInManager), ByVal context As IOwinContext) As ApplicationSignInManager
            Return New ApplicationSignInManager(context.GetUserManager(Of ApplicationUserManager)(), context.Authentication)
        End Function
    End Class
End Namespace
