﻿using GisGmp.Common;
using GisGmp.Services.ImportСertificates;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        public ImportCertificateRequest CreateImportCertificateRequest(ImportCertificateEntryType[] certificateEntries)
            => new ImportCertificateRequest(
                config: RequestConfig,
                entries: certificateEntries);
        
        public string ImportCertificate(ImportCertificateEntryType[] certificateEntries)
            => ReadyRequest(
                request:CreateImportCertificateRequest(
                    certificateEntries: certificateEntries));

        public ImportCertificateResponse CreateImportCertificateResponse(ImportProtocolType[] importProtocol)
            => new ImportCertificateResponse(
                config: ResponseConfig,
                importProtocol: importProtocol);  
    }
}
