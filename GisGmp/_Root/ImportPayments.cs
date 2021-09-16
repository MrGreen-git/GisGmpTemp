using GisGmp.Common;
using GisGmp.Package;
using GisGmp.Services.ImportPayments;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ImportPaymentsRequest CreateImportPaymentsRequest(ImportedPaymentType[] importedPaymentTypes)
            => new ImportPaymentsRequest(
                config: RequestConfig,
                package: new PaymentsPackage(
                    importedPayments: importedPaymentTypes));

        /// <summary/>
        public ImportPaymentsRequest CreateImportPaymentsRequest(ImportedChangeType[] importedChangeTypes)
            => new ImportPaymentsRequest(
                config: RequestConfig,
                package: new PaymentsPackage(
                    importedChanges: importedChangeTypes));

        #region ReadyRequest
        /// <summary/>
        public string ImportPayments(ImportedPaymentType[] importedPaymentTypes)
            => ReadyRequest(
                request: CreateImportPaymentsRequest(
                    importedPaymentTypes: importedPaymentTypes));

        /// <summary/>
        public string ImportPayments(ImportedChangeType[] importedChangeTypes)
            => ReadyRequest(
                request: CreateImportPaymentsRequest(
                    importedChangeTypes: importedChangeTypes));
        #endregion ReadyRequest

        /// <summary/>
        public ImportPaymentsResponse CreateImportPaymentsResponse(ImportProtocolType[] importProtocol)
            => new ImportPaymentsResponse(
                config: ResponseConfig,
                importProtocol: importProtocol);
    }
}
