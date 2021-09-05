using System;
using System.Collections.Generic;
using System.Text;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportIncomesRequest CreateExportIncomesRequest()
        {
            return new ExportNoticeRequest();
        }

        public ExportIncomesResponse CreateExportIncomesResponse()
        {
            return new ExportIncomesResponse();
        }
    }
}
