using GisGmp.Services.ExportCharges;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportChargesRequest CreateExportChargesRequest()
        {
            return new ExportChargesRequest();
        }

        public string ExportCharges()
            => ReadyRequest(CreateExportChargesRequest());


        public ExportChargesResponse CreateExportChargesResponse()
        {
            return new ExportChargesResponse();
        }
    }
}
