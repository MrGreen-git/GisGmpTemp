using GisGmp.Services.ExportNSI;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ExportNSIRequest CreateExportNSIRequest(NSIExportConditions nSIExportConditions, URNType urn)
            => new ExportNSIRequest(
                config: RequestConfig,
                nSIExportConditions: nSIExportConditions,
                originatorId: urn);

        
        //public string ExportNSI()
        //    => ReadyRequest(CreateExportNSIRequest());


        public ExportNSIResponse CreateExportNSIResponse()
        {
            throw new NotImplementedException();
        }
    }
}
