using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNSI
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0")]
    public class ExportNSIRequestNSIExportConditionsPayeeData
    {
        [XmlAttribute]
        public string inn { get; set; }

        [XmlAttribute]
        public string kpp { get; set; }
    }
}
