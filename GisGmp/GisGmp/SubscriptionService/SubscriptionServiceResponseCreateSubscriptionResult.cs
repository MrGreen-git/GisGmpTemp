using GisGmp.Subscription;
using System;
using System.Xml.Serialization;

namespace GisGmp.SubscriptionService
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
    public class SubscriptionServiceResponseCreateSubscriptionResult
    {
        [XmlElement("SubscriptionProtocol")]
        public SubscriptionProtocolType[] SubscriptionProtocol { get; set; }

        [XmlAttribute]
        public DateTime dispatchDate { get; set; }

        [XmlIgnore]
        public bool dispatchDateSpecified { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime expiryDate { get; set; }

        [XmlIgnore]
        public bool expiryDateSpecified { get; set; }

        [XmlAttribute]
        public string subscriptionCode { get; set; }

        [XmlAttribute]
        public string subscriptionIdentifier { get; set; }
    }
}
