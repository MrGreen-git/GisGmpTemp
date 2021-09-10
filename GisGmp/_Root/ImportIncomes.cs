
using GisGmp.Package;
using GisGmp.Services.ImportIncomes;
using GisGmp.Services.ImportPayments;

namespace GisGmp
{

    public partial class GisGmpBuilder
    {
        public ImportIncomesRequest CreateImportIncomesRequest(ImportedIncomeType[] importedIncomeTypes)
        {
            return new ImportIncomesRequest(
                config: RequestConfig,
                package: new IncomesPackage(
                    importedIncomes: importedIncomeTypes
                    )
                );
        }

        public string ImportPayments(ImportedIncomeType[] importedIncomeTypes)
            => ReadyRequest(CreateImportIncomesRequest(importedIncomeTypes));


        public ImportIncomesResponse CreateImportIncomesResponse()
        {
            //return new ImportIncomesResponse();
            return null;
        }
    }
}

