using System;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
    public class RefundTypeRefundBasis
    {
        [XmlAttribute]
        public string docKind { get; set; }

        [XmlAttribute]
        public string docNumber { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime docDate { get; set; }
    }
}
