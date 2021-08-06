
using GisGmp.Common;
using GisGmp.Services.ImportIncomes;
using GisGmp.Services.ImportPayments;

namespace GisGmp
{

    public partial class GisGmpBuilder
    {
        public ImportIncomesRequest CreateImportIncomesRequest()
        {
            return new ImportIncomesRequest(
                config: RequestConfig,
                package: 
                );
        }

        public string ImportPayments()
            => ReadyRequest(CreateImportIncomesRequest());


        public ImportIncomesResponse CreateImportIncomesResponse()
        {
            return new ImportIncomesResponse();
        }
    }
}

