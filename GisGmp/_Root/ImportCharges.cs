using GisGmp.Common;
using GisGmp.Package;
using GisGmp.Services.ImportCharges;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ImportChargesRequest CreateImportChargesRequest(ImportedChargeType[] importedChargeTypes)
            => new ImportChargesRequest(
                config: RequestConfig,
                package: new ChargesPackage(
                    importedCharges: importedChargeTypes));

        /// <summary/>
        public ImportChargesRequest CreateImportChargesRequest(ImportedChangeType[] importedChangeTypes)
            => new ImportChargesRequest(
                config: RequestConfig,
                package: new ChargesPackage(
                    importedChanges: importedChangeTypes));

        #region ReadyRequest
        /// <summary/>
        public string ImportCharges(ImportedChargeType[] importedChargeTypes)
            => ReadyRequest(
                request: CreateImportChargesRequest(
                    importedChargeTypes: importedChargeTypes));

        /// <summary/>
        public string ImportCharges(ImportedChangeType[] importedChangeTypes)
            => ReadyRequest(
                request: CreateImportChargesRequest(
                    importedChangeTypes: importedChangeTypes));
        #endregion

        /// <summary/>
        public ImportChargesResponse CreateImportChargesResponse(ImportProtocolType[] importProtocol)
            => new ImportChargesResponse(
                config: ResponseConfig,
                importProtocol: importProtocol);
    }
}
