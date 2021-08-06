using GisGmp.Services.ExportNSI;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportNSIRequest CreateExportNSIRequest()
        {
            return new ExportNSIRequest();
        }

        public string ExportNSI()
            => ReadyRequest(CreateExportNSIRequest());


        public ExportNSIResponse CreateExportNSIResponse()
        {
            return new ExportNSIResponse();
        }
    }
}
