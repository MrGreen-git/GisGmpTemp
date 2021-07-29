using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class ImportCertificateEntryType
    {
        [XmlAttribute(DataType = "IDREF")]
        public string Id { get; set; }

        [XmlAttribute]
        public string ownership { get; set; }
    }
}
