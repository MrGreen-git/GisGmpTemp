using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAckmowledgement
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    public class PaymentDataID
    {
        [XmlAttribute]
        public string paymentId { get; set; }

        [XmlAttribute]
        public string serviceDataID { get; set; }
    }
}
