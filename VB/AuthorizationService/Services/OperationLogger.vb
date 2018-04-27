Imports DevExpress.XtraReports.Web.WebDocumentViewer
Imports System.Collections.Concurrent
Imports System.Web
Imports System
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.Web.ClientControls
Imports DevExpress.XtraReports.UI

Namespace AuthorizationService.Services
    Public Class OperationLogger
        Inherits WebDocumentViewerOperationLogger
        Implements IWebDocumentViewerAuthorizationService, IExportingAuthorizationService

#Region "WebDocumentViewerOperationLogger"
        Public Overrides Sub ReportOpening(ByVal reportId As String, ByVal documentId As String, ByVal report As XtraReport)
            If HttpContext.Current.Session Is Nothing Then
                Return
            End If
            SaveUsedEntityId(Constants.ReportDictionaryName, reportId)
            SaveUsedEntityId(Constants.DocumentDictionaryName, documentId)
        End Sub

        Public Overrides Sub BuildStarted(ByVal reportId As String, ByVal documentId As String, ByVal buildProperties As ReportBuildProperties)
            SaveUsedEntityId(Constants.ReportDictionaryName, reportId)
            SaveUsedEntityId(Constants.DocumentDictionaryName, documentId)
        End Sub

        Public Overrides Function ExportDocumentStarting(ByVal documentId As String, ByVal asyncExportOperationId As String, ByVal format As String, ByVal options As ExportOptions, ByVal printingSystem As PrintingSystemBase, ByVal doExportSynchronously As Func(Of ExportedDocument)) As ExportedDocument
            SaveUsedEntityId(Constants.ExportedDocumentDictionaryName, asyncExportOperationId)
            Return MyBase.ExportDocumentStarting(documentId, asyncExportOperationId, format, options, printingSystem, doExportSynchronously)
        End Function

        Public Overrides Sub ReleaseDocument(ByVal documentId As String)

        End Sub
#End Region ' WebDocumentViewerOperationLogger

#Region "IWebDocumentViewerAuthorizationService"
        Private Function IWebDocumentViewerAuthorizationService_CanCreateDocument() As Boolean Implements IWebDocumentViewerAuthorizationService.CanCreateDocument
            Return CheckUserAuthorized()
        End Function

        Private Function IWebDocumentViewerAuthorizationService_CanCreateReport() As Boolean Implements IWebDocumentViewerAuthorizationService.CanCreateReport
            Return CheckUserAuthorized()
        End Function

        Private Function IWebDocumentViewerAuthorizationService_CanReadDocument(ByVal documentId As String) As Boolean Implements IWebDocumentViewerAuthorizationService.CanReadDocument
            Return CheckEntityAvailability(Constants.DocumentDictionaryName, documentId)
        End Function

        Private Function IWebDocumentViewerAuthorizationService_CanReadReport(ByVal reportId As String) As Boolean Implements IWebDocumentViewerAuthorizationService.CanReadReport
            Return CheckEntityAvailability(Constants.ReportDictionaryName, reportId)
        End Function

        Private Function IWebDocumentViewerAuthorizationService_CanReleaseDocument(ByVal documentId As String) As Boolean Implements IWebDocumentViewerAuthorizationService.CanReleaseDocument
            Return CheckEntityAvailability(Constants.DocumentDictionaryName, documentId)
        End Function

        Private Function IWebDocumentViewerAuthorizationService_CanReleaseReport(ByVal reportId As String) As Boolean Implements IWebDocumentViewerAuthorizationService.CanReleaseReport
            Return CheckEntityAvailability(Constants.ReportDictionaryName, reportId)
        End Function

        Private Function IWebDocumentViewerAuthorizationService_CanReadExportedDocument(ByVal exportDocumentId As String) As Boolean Implements IExportingAuthorizationService.CanReadExportedDocument
            Return CheckEntityAvailability(Constants.ExportedDocumentDictionaryName, exportDocumentId)
        End Function
#End Region ' IWebDocumentViewerAuthorizationService, IExportingAuthorizationService

        Private Function CheckUserAuthorized() As Boolean
            Dim user = HttpContext.Current.User
            If user Is Nothing OrElse user.Identity Is Nothing OrElse Not user.Identity.IsAuthenticated Then
                Return False
            End If
            Return True
        End Function

        Private Sub SaveUsedEntityId(ByVal dictionaryName As String, ByVal id As String)
            If String.IsNullOrEmpty(id) Then
                Return
            End If

            Dim dictionary As ConcurrentDictionary(Of String, Boolean) = Nothing
            SyncLock HttpContext.Current.Session.SyncRoot
                If HttpContext.Current.Session(dictionaryName) Is Nothing Then
                    dictionary = New ConcurrentDictionary(Of String, Boolean)()
                    HttpContext.Current.Session(dictionaryName) = dictionary
                End If
            End SyncLock
            If dictionary Is Nothing Then
                dictionary = (DirectCast(HttpContext.Current.Session(dictionaryName), ConcurrentDictionary(Of String, Boolean)))
            End If
            dictionary.AddOrUpdate(id, False, Function(_1, _2) False)
        End Sub

        Private Function CheckEntityAvailability(ByVal dictionaryName As String, ByVal id As String) As Boolean
            If String.IsNullOrEmpty(id) OrElse Not CheckUserAuthorized() Then
                Return False
            End If

            SyncLock HttpContext.Current.Session.SyncRoot
                If HttpContext.Current.Session(dictionaryName) Is Nothing Then
                    Return False
                End If
            End SyncLock
            Return DirectCast(HttpContext.Current.Session(dictionaryName), ConcurrentDictionary(Of String, Boolean)).ContainsKey(id)
        End Function

        Private Sub DisposeEntityRequested(ByVal dictionaryName As String, ByVal id As String)
            If String.IsNullOrEmpty(id) Then
                Return
            End If
            SyncLock HttpContext.Current.Session.SyncRoot
                If HttpContext.Current.Session(dictionaryName) Is Nothing Then
                    Return
                End If
            End SyncLock
            DirectCast(HttpContext.Current.Session(dictionaryName), ConcurrentDictionary(Of String, Boolean)).AddOrUpdate(id, True, Function(_1, _2) True)
        End Sub
    End Class
End Namespace