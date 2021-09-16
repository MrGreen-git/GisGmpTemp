using GisGmp.Common;
using GisGmp.Package;
using GisGmp.Services.ImportRenouncement;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ImportRenouncementRequest CreateImportRenouncementRequest(ImportedRenouncementType[] importedRenouncementTypes)
            => new ImportRenouncementRequest(
                config: RequestConfig,
                package: new RenouncementPackage(
                    importedRenouncements: importedRenouncementTypes));

        /// <summary/>
        public ImportRenouncementResponse CreateImportRenouncementResponse(ImportProtocolType[] importProtocol)
            => new ImportRenouncementResponse(
                config: ResponseConfig,
                importProtocol: importProtocol);
    }
}
