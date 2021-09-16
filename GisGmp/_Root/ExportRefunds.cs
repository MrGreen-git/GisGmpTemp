using GisGmp.Services.ExportRefunds;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportRefundsRequest CreateExportRefundsRequest()
        {
            throw new NotImplementedException();
        }

        public string ExportRefunds()
            => ReadyRequest(CreateExportRefundsRequest());


        

        public ExportRefundsResponse CreateExportRefundsResponse(bool hasMore, Services.ExportRefunds.Refund[] refund)
            => new ExportRefundsResponse(
                config: ResponseConfig,
                hasMore: hasMore,
                refund: refund);
    }
}
