using GisGmp.Common;
using GisGmp.Package;
using GisGmp.Services.ImportIncomes;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ImportIncomesRequest CreateImportIncomesRequest(ImportedIncomeType[] importedIncomeTypes)
            => new ImportIncomesRequest(
                config: RequestConfig,
                package: new IncomesPackage(
                    importedIncomes: importedIncomeTypes));

        #region ReadyRequest
        /// <summary/>
        public string ImportPayments(ImportedIncomeType[] importedIncomeTypes)
            => ReadyRequest(
                request: CreateImportIncomesRequest(
                    importedIncomeTypes: importedIncomeTypes));
        #endregion

        /// <summary/>
        public ImportIncomesResponse CreateImportIncomesResponse(ImportProtocolType[] importProtocol)
            => new ImportIncomesResponse(
                config: ResponseConfig,
                importProtocol: importProtocol);
    }
}

