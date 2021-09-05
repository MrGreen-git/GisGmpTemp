using GisGmp.Common;
using GisGmp.Services.ImportСertificates;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ImportCertificateRequest CreateImportCertificateRequest(ImportCertificateEntryType[] certificateEntries)
        {
            return new ImportCertificateRequest(
                config: RequestConfig,
                entries: certificateEntries
                );
        }

        public string ImportCertificate(ImportCertificateEntryType[] certificateEntries)
            => ReadyRequest(CreateImportCertificateRequest(certificateEntries));


        public ImportCertificateResponse CreateImportCertificateResponse(ImportProtocolType[] importProtocol)
        {
            return new ImportCertificateResponse(
                config: ResponseConfig,
                importProtocol: importProtocol
                );
        }
    }
}
