using GisGmp.Charge;
using GisGmp.Payment;
using GisGmp.Refund;
using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [XmlInclude(typeof(PayeeType))]
    [XmlInclude(typeof(PayerType2))]
    [XmlInclude(typeof(PayerType1))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class PayerType
    {
        [XmlAttribute]
        public string payerIdentifier { get; set; }
    }
}
