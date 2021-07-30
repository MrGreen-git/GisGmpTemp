using GisGmp.Common;
using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportRefunds
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-refunds/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-refunds/2.4.0", IsNullable = false)]
    public class ImportRefundsRequest : RequestType
    {
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
        public RefundsPackage RefundsPackage { get; set; }
    }
}
