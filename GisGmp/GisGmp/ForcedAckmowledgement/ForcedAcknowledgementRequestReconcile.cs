using System;
using System.Xml.Serialization;

namespace GisGmp.ForcedAckmowledgement
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    public class ForcedAcknowledgementRequestReconcile
    {
        [XmlElement("PaymentId", typeof(string))]
        [XmlElement("PaymentNotLoaded", typeof(ForcedAcknowledgementRequestReconcilePaymentNotLoaded))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public string supplierBillId { get; set; }
    }
}
