using GisGmp.Common;
using GisGmp.SearchConditions;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0", IsNullable = false)]
    public class ExportPaymentsRequest : ExportRequestType
    {
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.4.0")]
        public PaymentsExportConditions PaymentsExportConditions { get; set; }
    }
}
