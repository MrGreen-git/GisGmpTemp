using GisGmp.Services.ExportQuittances;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportQuittancesRequest CreateExportQuittancesRequest()
        {
            throw new NotImplementedException();
        }

        public string ExportQuittances()
            => ReadyRequest(CreateExportQuittancesRequest());


        public ExportQuittancesResponse CreateExportQuittancesResponse()
        {
            throw new NotImplementedException();
        }
    }
}
