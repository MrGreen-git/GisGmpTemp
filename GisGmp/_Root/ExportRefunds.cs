using GisGmp.SearchConditions;
using GisGmp.Services.ExportRefunds;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportRefundsRequest CreateExportRefundsRequest(ExportRefundsKind kind, UIP[] uip)
        {
            return new ExportRefundsRequest(
                config: ExportRequestConfig,
                exportConditions: new RefundsExportConditions(
                    kind: kind,
                    conditions: new PaymentsConditionsType(
                        uip: uip)));
        }

        //public string ExportRefunds()
        //    => ReadyRequest(CreateExportRefundsRequest());


        public ExportRefundsResponse CreateExportRefundsResponse(bool hasMore, Services.ExportRefunds.Refund[] refund)
            => new ExportRefundsResponse(
                config: ResponseConfig,
                hasMore: hasMore,
                refund: refund);
    }
}
