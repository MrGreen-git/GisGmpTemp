using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportСertificates
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.4.0", IsNullable = false)]
    public class ImportCertificateResponse : ResponseType
    {
        [XmlElement("ImportProtocol")]
        public ImportProtocolType[] ImportProtocol { get; set; }
    }
}
