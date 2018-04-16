Imports Microsoft.Owin
Imports Owin

<Assembly: OwinStartupAttribute(GetType(AuthorizationService.Startup))>
Namespace AuthorizationService
    Partial Public Class Startup
        Public Sub Configuration(ByVal app As IAppBuilder)
            ConfigureAuth(app)
        End Sub
    End Class
End Namespace
