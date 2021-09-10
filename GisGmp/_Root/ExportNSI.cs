using GisGmp.Services.ExportNSI;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportNSIRequest CreateExportNSIRequest()
        {
            throw new NotImplementedException();
        }

        public string ExportNSI()
            => ReadyRequest(CreateExportNSIRequest());


        public ExportNSIResponse CreateExportNSIResponse()
        {
            throw new NotImplementedException();
        }
    }
}
