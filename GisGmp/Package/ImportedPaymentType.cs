using GisGmp.Payment;
using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public class ImportedPaymentType : PaymentType
    {
        [XmlAttribute]
        public string originatorId { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        [XmlAttribute]
        public ImportedPaymentTypePaymentMethod paymentMethod { get; set; }

        [XmlIgnore]
        public bool paymentMethodSpecified { get; set; }

        [XmlAttribute]
        public string requisiteCheckCode { get; set; }
    }
}
