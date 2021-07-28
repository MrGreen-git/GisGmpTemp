using System;
using System.Xml.Serialization;

namespace GisGmp.Payment
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.4.0")]
    public class PaymentTypePartialPayt
    {
        public AccDocType AccDoc { get; set; }

        [XmlAttribute]
        public TransKindType transKind { get; set; }

        [XmlAttribute]
        public string paytNo { get; set; }

        [XmlAttribute]
        public string transContent { get; set; }

        [XmlAttribute(DataType = "integer")]
        public string sumResidualPayt { get; set; }
    }
}
