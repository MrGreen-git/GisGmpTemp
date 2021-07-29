using System;
using System.Xml.Serialization;

namespace GisGmp.ForcedAckmowledgement
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    public class ForcedAcknowledgementRequestAnnulmentServiceProvided
    {
        [XmlElement("PaymentDataID")]
        public ForcedAcknowledgementRequestAnnulmentServiceProvidedPaymentDataID[] PaymentDataID { get; set; }
    }
}
