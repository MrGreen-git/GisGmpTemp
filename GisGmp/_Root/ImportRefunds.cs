using GisGmp.Common;
using GisGmp.Package;
using GisGmp.Services.ImportRefunds;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ImportRefundsRequest CreateImportRefundsRequest(ImportedRefundType[] importedRefundTypes)
            => new ImportRefundsRequest(
                config: RequestConfig,
                package: new RefundsPackage(
                    importedRefunds: importedRefundTypes));

        /// <summary/>
        public ImportRefundsRequest CreateImportRefundsRequest(ImportedChangeType[] importedChangeTypes)
            => new ImportRefundsRequest(
                config: RequestConfig,
                package: new RefundsPackage(
                    importedChanges: importedChangeTypes));

        #region ReadyRequest
        /// <summary/>
        public string ImportRefunds(ImportedRefundType[] importedRefundTypes)
            => ReadyRequest(
                request: CreateImportRefundsRequest(
                    importedRefundTypes: importedRefundTypes));

        /// <summary/>
        public string ImportRefunds(ImportedChangeType[] importedChangeTypes)
            => ReadyRequest(
                request: CreateImportRefundsRequest(
                    importedChangeTypes: importedChangeTypes));
        #endregion

        /// <summary/>
        public ImportRefundsResponse CreateImportRefundsResponse(ImportProtocolType[] importProtocol)
            => new ImportRefundsResponse(
                config: ResponseConfig,
                importProtocol: importProtocol);
    }
}
