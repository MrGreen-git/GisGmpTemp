using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Payment
{
    [XmlInclude(typeof(ImportedPaymentType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.4.0")]
    public class PaymentType : PaymentBaseType
    {
        public PaymentTypePartialPayt PartialPayt { get; set; }

        [XmlAttribute]
        public string paymentId { get; set; }

        [XmlAttribute]
        public DateTime paymentDate { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime deliveryDate { get; set; }

        [XmlIgnore]
        public bool deliveryDateSpecified { get; set; }

        [XmlAttribute]
        public string ESIA_ID { get; set; }
    }
}
