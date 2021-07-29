using GisGmp.Common;
using GisGmp.CommonNSI;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNSI
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0", IsNullable = false)]
    public class ExportNSIResponse : ResponseType
    {
        [XmlElement("PayeeNSIInfo", typeof(PayeeNSIInfoType))]
        [XmlElement("oktmoNSIInfo", typeof(oktmoNSIInfoType))]
        public object Item { get; set; }
    }
}
