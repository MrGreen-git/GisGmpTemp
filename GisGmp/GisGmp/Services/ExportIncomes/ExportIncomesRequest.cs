using GisGmp.Common;
using GisGmp.SearchConditions;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportIncomes
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-incomes/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-incomes/2.4.0", IsNullable = false)]
    public class ExportIncomesRequest : ExportRequestType
    {
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
        public IncomesExportConditions IncomesExportConditions { get; set; }
    }
}
