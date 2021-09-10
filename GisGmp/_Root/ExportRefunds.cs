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


        public ExportRefundsResponse CreateExportRefundsResponse()
        {
            throw new NotImplementedException();
        }
    }
}
