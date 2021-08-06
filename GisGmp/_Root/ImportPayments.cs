using GisGmp.Services.ImportPayments;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ImportPaymentsRequest CreateImportPaymentsRequest()
        {
            return new ImportPaymentsRequest();
        }

        public string ImportPayments()
            => ReadyRequest(CreateImportPaymentsRequest());


        public ImportPaymentsResponse CreateImportPaymentsResponse(I)
        {
            return new ImportPaymentsResponse();
        }
    }
}
