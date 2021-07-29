using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportClarification
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-clarification/2.4.0", IsNullable = false)]
    public class ExportClarificationResponse : ResponseType
    {
        [XmlElement("ClarificationInfo")]
        public ClarificationInfo[] ClarificationInfo { get; set; }

        [XmlAttribute]
        public bool hasMore { get; set; }
    }
}
