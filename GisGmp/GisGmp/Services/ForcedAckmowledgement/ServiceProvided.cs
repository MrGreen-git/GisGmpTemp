using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAckmowledgement
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.4.0")]
    public class ServiceProvided
    {
        [XmlElement("PaymentDataInfo")]
        public PaymentDataInfo[] PaymentDataInfo { get; set; }
    }
}
