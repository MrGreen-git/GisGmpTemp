using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNoticeNSI
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.4.0", IsNullable = false)]
    public class ExportNoticeNSIResponse : ResponseType
    {
        public string RoutingCode { get; set; }

        public bool ExportNoticeNSIConfirmation { get; set; }
    }
}
