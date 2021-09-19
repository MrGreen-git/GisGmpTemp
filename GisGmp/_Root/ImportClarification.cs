using GisGmp.Common;
using GisGmp.Package;
using GisGmp.Services.ImportClarification;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ImportClarificationRequest CreateImportClarificationRequest(ImportedClarificationType[] importedClarificationTypes)
            => new ImportClarificationRequest(
                config: RequestConfig,
                package: new ClarificationsPackage(
                    importedClarification: importedClarificationTypes));

        #region ReadyRequest
        /// <summary/>
        //public string ImportCharges(ImportedChargeType[] importedChargeTypes)
        //    => ReadyRequest(
        //        request: CreateImportChargesRequest(
        //            importedChargeTypes: importedChargeTypes));

        #endregion

        /// <summary/>
        public ImportClarificationResponse CreateImportClarificationResponse(ImportProtocolType[] importProtocol)
            => new ImportClarificationResponse(
                config: ResponseConfig,
                importProtocol: importProtocol);
    }
}
