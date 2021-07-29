using GisGmp.CommonNSI;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNoticeNSI
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0")]
    public class NoticeNSI
    {
        [XmlElement("PayeeNSIInfo", typeof(PayeeNSIInfoType))]
        [XmlElement("oktmoNSIInfo", typeof(oktmoNSIInfoType))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public string directoryCode { get; set; }
    }
}
