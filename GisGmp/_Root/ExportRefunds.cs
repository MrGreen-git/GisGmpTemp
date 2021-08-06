using GisGmp.Services.ExportRefunds;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportRefundsRequest CreateExportRefundsRequest()
        {
            return new ExportRefundsRequest();
        }

        public string ExportRefunds()
            => ReadyRequest(CreateExportRefundsRequest());


        public ExportRefundsResponse CreateExportRefundsResponse()
        {
            return new ExportRefundsResponse();
        }
    }
}
