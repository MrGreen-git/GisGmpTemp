using System;
using System.Xml.Serialization;

namespace GisGmp.Charge
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0", IsNullable = false)]
    public class Payer : PayerType1
    {
        [XmlAttribute]
        public string payerName { get; set; }

        [XmlAttribute]
        public string additionalPayerIdentifier { get; set; }
    }
}
