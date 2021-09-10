using GisGmp.Services.ExportCharges;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportChargesRequest CreateExportChargesRequest()
        {
            throw new NotImplementedException();
        }

        public string ExportCharges()
            => ReadyRequest(CreateExportChargesRequest());


        public ExportChargesResponse CreateExportChargesResponse()
        {
            throw new NotImplementedException();
        }
    }
}
