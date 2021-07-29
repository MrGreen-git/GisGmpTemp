using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNSI
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0")]
    public class ExportNSIRequestNSIExportConditions
    {
        [XmlElement("PayeeData", typeof(ExportNSIRequestNSIExportConditionsPayeeData))]
        [XmlElement("oktmo", typeof(string))]
        public object Item { get; set; }
    }
}
