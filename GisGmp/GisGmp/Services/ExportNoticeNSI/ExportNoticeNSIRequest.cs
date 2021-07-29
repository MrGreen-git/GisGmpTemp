using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNoticeNSI
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0", IsNullable = false)]
    public class ExportNoticeNSIRequest
    {
        public ExportNoticeNSIRequestDestination Destination { get; set; }

        public ExportNoticeNSIRequestNoticeNSI NoticeNSI { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        [XmlAttribute]
        public DateTime timestamp { get; set; }
    }
}
