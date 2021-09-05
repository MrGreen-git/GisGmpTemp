using GisGmp.Services.ExportClarification;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportClarificationRequest CreateExportClarificationRequest()
        {
            return new ExportClarificationRequest();
        }

        public string ExportClarification()
            => ReadyRequest(CreateExportClarificationRequest());


        public ExportClarificationResponse CreateExportClarificationResponse()
        {
            return new ExportClarificationResponse();
        }
    }
}
