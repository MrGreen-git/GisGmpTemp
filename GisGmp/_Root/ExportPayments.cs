using GisGmp.Services.ExportPayments;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportPaymentsRequest CreateExportPaymentsRequest()
        {
            throw new NotImplementedException();
        }

        public string ExportPayments()
            => ReadyRequest(CreateExportPaymentsRequest());


        public ExportPaymentsResponse CreateExportPaymentsResponse()
        {
            throw new NotImplementedException();
        }
    }
}
