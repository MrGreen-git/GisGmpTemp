using GisGmp.Services.ImportСertificates;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ImportCertificateRequest CreateImportCertificateRequest()
        {
            return new ImportCertificateRequest();
        }

        public string ImportCertificate()
            => ReadyRequest(CreateImportCertificateRequest());


        public ImportCertificateResponse CreateImportCertificateResponse()
        {
            return new ImportCertificateResponse();
        }
    }
}
