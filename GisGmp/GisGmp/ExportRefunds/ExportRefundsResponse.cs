using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.ExportRefunds
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.4.0", IsNullable = false)]
    public class ExportRefundsResponse : ResponseType
    {
        [XmlElement("Refund")]
        public ExportRefundsResponseRefund[] Refund { get; set; }

        [XmlAttribute]
        public bool hasMore { get; set; }
    }
}
