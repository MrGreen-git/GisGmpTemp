using GisGmp.NoticeCharge;
using GisGmp.Renouncement;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNotice
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0", IsNullable = false)]
    public class ExportNoticeRequest
    {
        public Destination Destination { get; set; }

        [XmlElement("NoticeCharge", typeof(NoticeCharge))]
        [XmlElement("NoticeChargeExecutive", typeof(NoticeChargeExecutiveType))]
        [XmlElement("NoticePayment", typeof(NoticePayment))]
        [XmlElement("NoticeQuittance", typeof(NoticeQuittance))]
        [XmlElement("NoticeRenouncement", typeof(RenouncementType))]
        public object[] Items { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        [XmlAttribute]
        public DateTime timestamp { get; set; }
    }
}
