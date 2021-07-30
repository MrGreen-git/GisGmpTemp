using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Payment
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.4.0")]
    [XmlRoot("Payer", Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.4.0", IsNullable = false)]
    public class Payer1 : PayerType
    {
        [XmlAttribute]
        public string payerName { get; set; }

        [XmlAttribute]
        public string payerAccount { get; set; }
    }
}
