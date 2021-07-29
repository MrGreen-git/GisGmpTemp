using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNoticeNSI
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0")]
    public class Destination
    {
        public string RoutingCode { get; set; }

        [XmlAttribute]
        public string recipientIdentifier { get; set; }
    }
}
