using GisGmp.Services.ExportPayments;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportPaymentsRequest CreateExportPaymentsRequest()
        {
            return new ExportPaymentsRequest();
        }

        public string ExportPayments()
            => ReadyRequest(CreateExportPaymentsRequest());


        public ExportPaymentsResponse CreateExportPaymentsResponse()
        {
            return new ExportPaymentsResponse();
        }
    }
}
