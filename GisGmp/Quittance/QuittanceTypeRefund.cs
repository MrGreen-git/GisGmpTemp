using System;
using System.Xml.Serialization;

namespace GisGmp.Quittance
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Quittance/2.4.0")]
    public class QuittanceTypeRefund
    {
        [XmlAttribute]
        public string refundId { get; set; }

        [XmlAttribute]
        public ulong amount { get; set; }
    }
}
