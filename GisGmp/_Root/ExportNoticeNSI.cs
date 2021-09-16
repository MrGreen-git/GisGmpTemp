using GisGmp.Services.ExportNoticeNSI;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ExportNoticeNSIRequest CreateExportNoticeNSIRequest(Destination destination, NoticeNSI noticeNSI)
            => new ExportNoticeNSIRequest(
                id: Id,
                timestamp: Timestamp,
                destination: destination,
                noticeNSI: noticeNSI);

        /// <summary/>
        //public string ExportNoticeNSI(Destination destination, NoticeNSI noticeNSI)
        //    => ReadyRequest(
        //        request: CreateExportNoticeNSIRequest(
        //            destination: destination,
        //            noticeNSI: noticeNSI));

        /// <summary/>
        public ExportNoticeNSIResponse CreateExportNoticeNSIResponse(string routingCode, bool exportNoticeNSIConfirmation)
            => new ExportNoticeNSIResponse(
                config: ResponseConfig,
                routingCode: routingCode,
                exportNoticeNSIConfirmation: exportNoticeNSIConfirmation);
    }
}
