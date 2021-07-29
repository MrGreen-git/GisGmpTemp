using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.ExportQuittances
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0", IsNullable = false)]
    public class ExportQuittancesRequest : ExportRequestType
    {
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
        public QuittancesExportConditions QuittancesExportConditions { get; set; }
    }
}
