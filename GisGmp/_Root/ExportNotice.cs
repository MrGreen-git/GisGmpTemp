using GisGmp.Services.ExportNotice;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportNoticeRequest CreateExportNoticeRequest()
        {
            return new ExportNoticeRequest();
        }

        //public string ExportNotice()
        //    => ReadyRequest(CreateExportNoticeRequest());


        public ExportNoticeResponse CreateExportNoticeResponse()
        {
            return new ExportNoticeResponse();
        }
    }
}
