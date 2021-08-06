using GisGmp.Common;
using GisGmp.Quittance;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportQuittances;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportQuittancesRequest CreateExportQuittancesRequest()
        {
            return new ExportQuittancesRequest();
        }

        public string ExportQuittances()
            => ReadyRequest(CreateExportQuittancesRequest());


        public ExportQuittancesResponse CreateExportQuittancesResponse()
        {
            return new ExportQuittancesResponse();
        }
    }
}
