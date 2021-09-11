using GisGmp.Package;
using GisGmp.Services.ImportRenouncement;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ImportRenouncementRequest CreateImportRenouncementRequest(ImportedRenouncementType[] importedRenouncementTypes)
        {
            return new ImportRenouncementRequest(
                config: RequestConfig,
                package: new RenouncementPackage(
                    importedRenouncements: importedRenouncementTypes
                    )
                );
        }
    }
}
