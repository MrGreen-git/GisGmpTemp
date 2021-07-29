using System;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
    public class RefundTypeRefundApplication
    {
        [XmlAttribute]
        public string appNum { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime appDate { get; set; }

        [XmlAttribute]
        public string paymentId { get; set; }

        [XmlAttribute]
        public int cashType { get; set; }

        [XmlAttribute]
        public ulong amount { get; set; }

        [XmlAttribute]
        public string purpose { get; set; }
    }
}
