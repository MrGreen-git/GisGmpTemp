using GisGmp.Services.ExportNoticeNSI;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportNoticeNSIRequest CreateExportNoticeNSIRequest()
        {
            return new ExportNoticeNSIRequest();
        }

        public string ExportNoticeNSI()
            => throw new NotImplementedException();


        public ExportNoticeNSIResponse CreateExportNoticeNSIResponse()
        {
            return new ExportNoticeNSIResponse();
        }
    }
}
