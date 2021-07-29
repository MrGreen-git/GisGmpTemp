using System;
using System.Xml.Serialization;

namespace GisGmp.ExportQuittances
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.4.0")]
    public class ExportQuittancesResponsePossibleData
    {
        [XmlElement("ComparisonResult")]
        public ExportQuittancesResponsePossibleDataComparisonResult[] ComparisonResult { get; set; }

        [XmlAttribute]
        public string supplierBillID { get; set; }

        [XmlAttribute]
        public ulong totalAmount { get; set; }

        [XmlIgnore]
        public bool totalAmountSpecified { get; set; }
    }
}
