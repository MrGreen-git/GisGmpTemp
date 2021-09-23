using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNSI
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0")]
    public class NSIExportConditions
    {
        [XmlElement("PayeeData", typeof(PayeeData))]
        [XmlElement("oktmo", typeof(string))]
        public object Item { get; set; }

        [XmlIgnore]
        public PayeeData PayeeData { get; set; }
    }
}
