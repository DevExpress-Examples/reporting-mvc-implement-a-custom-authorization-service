using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using System.Collections.Concurrent;
using System.Web;
using System;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.Web.ClientControls;

namespace AuthorizationService.Services {
    public class OperationLogger: WebDocumentViewerOperationLogger, IWebDocumentViewerAuthorizationService, IExportingAuthorizationService
    {
        #region WebDocumentViewerOperationLogger
        public override void ReportOpening(string reportId, string documentId, XtraReport report) {
            if (HttpContext.Current.Session == null) {
                return;
            }
            SaveUsedEntityId(Constants.ReportDictionaryName, reportId);
            SaveUsedEntityId(Constants.DocumentDictionaryName, documentId);
        }

        public override void BuildStarted(string reportId, string documentId, ReportBuildProperties buildProperties) {
            SaveUsedEntityId(Constants.ReportDictionaryName, reportId);
            SaveUsedEntityId(Constants.DocumentDictionaryName, documentId);
        }

        public override ExportedDocument ExportDocumentStarting(string documentId, string asyncExportOperationId, string format, ExportOptions options, PrintingSystemBase printingSystem, Func<ExportedDocument> doExportSynchronously) {
            SaveUsedEntityId(Constants.ExportedDocumentDictionaryName, asyncExportOperationId);
            return base.ExportDocumentStarting(documentId, asyncExportOperationId, format, options, printingSystem, doExportSynchronously);
        }

        public override void ReleaseDocument(string documentId) {
            
        }
        #endregion WebDocumentViewerOperationLogger

        #region IWebDocumentViewerAuthorizationService
        bool IWebDocumentViewerAuthorizationService.CanCreateDocument() {
            return CheckUserAuthorized();
        }

        bool IWebDocumentViewerAuthorizationService.CanCreateReport() {
            return CheckUserAuthorized();
        }

        bool IWebDocumentViewerAuthorizationService.CanReadDocument(string documentId) {
            return CheckEntityAvailability(Constants.DocumentDictionaryName, documentId);
        }

        bool IWebDocumentViewerAuthorizationService.CanReadReport(string reportId) {
            return CheckEntityAvailability(Constants.ReportDictionaryName, reportId);
        }

        bool IWebDocumentViewerAuthorizationService.CanReleaseDocument(string documentId) {
            return CheckEntityAvailability(Constants.DocumentDictionaryName, documentId);
        }

        bool IWebDocumentViewerAuthorizationService.CanReleaseReport(string reportId) {
            return CheckEntityAvailability(Constants.ReportDictionaryName, reportId);
        }

        public bool CanReadExportedDocument(string exportDocumentId) {
            return CheckEntityAvailability(Constants.ExportedDocumentDictionaryName, exportDocumentId);
        }
        #endregion IWebDocumentViewerAuthorizationService, IExportingAuthorizationService

        bool CheckUserAuthorized() {
            var user = HttpContext.Current.User;
            if (user == null || user.Identity == null || !user.Identity.IsAuthenticated)
            {
                return false;
            }
            return true;
        }

        void SaveUsedEntityId(string dictionaryName, string id) {
            if (string.IsNullOrEmpty(id))
                return;

            ConcurrentDictionary<string, bool> dictionary = null;
            lock (HttpContext.Current.Session.SyncRoot) {
                if (HttpContext.Current.Session[dictionaryName] == null)
                     HttpContext.Current.Session[dictionaryName] = dictionary = new ConcurrentDictionary<string, bool>();
            }
            if (dictionary == null)
                dictionary = ((ConcurrentDictionary<string, bool>)HttpContext.Current.Session[dictionaryName]);
            dictionary.AddOrUpdate(id, false, (_1, _2) => false);
        }

        bool CheckEntityAvailability(string dictionaryName, string id) {
            if (string.IsNullOrEmpty(id) || !CheckUserAuthorized())
                return false;

            lock (HttpContext.Current.Session.SyncRoot) {
                if (HttpContext.Current.Session[dictionaryName] == null)
                    return false;
            }
            return ((ConcurrentDictionary<string, bool>)HttpContext.Current.Session[dictionaryName]).ContainsKey(id);
        }

        void DisposeEntityRequested(string dictionaryName, string id) {
            if (string.IsNullOrEmpty(id))
                return;
            lock (HttpContext.Current.Session.SyncRoot) {
                if (HttpContext.Current.Session[dictionaryName] == null)
                    return;
            }
            ((ConcurrentDictionary<string, bool>)HttpContext.Current.Session[dictionaryName]).AddOrUpdate(id, true, (_1, _2) => true);
        }
    }
}