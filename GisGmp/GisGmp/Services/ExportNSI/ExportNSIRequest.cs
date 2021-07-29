using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNSI
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.4.0", IsNullable = false)]
    public class ExportNSIRequest : RequestType
    {
        public ExportNSIRequestNSIExportConditions NSIExportConditions { get; set; }

        [XmlAttribute]
        public string originatorId { get; set; }
    }
}
