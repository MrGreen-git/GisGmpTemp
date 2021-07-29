using GisGmp.Organization;
using System;
using System.Xml.Serialization;

namespace GisGmp.ImportPaymentCheck
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0")]
    public class PaymentCheckRequestPaymentTemplate
    {
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
        public Payee Payee { get; set; }

        [XmlAttribute]
        public string supplierBillID { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime receiptDate { get; set; }

        [XmlIgnore]
        public bool receiptDateSpecified { get; set; }

        [XmlAttribute]
        public string kbk { get; set; }

        [XmlAttribute]
        public string oktmo { get; set; }
    }
}
