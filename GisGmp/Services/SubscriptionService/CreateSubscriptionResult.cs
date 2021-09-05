using GisGmp.Subscription;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
    public class CreateSubscriptionResult
    {
        [XmlElement("SubscriptionProtocol")]
        public SubscriptionProtocolType[] SubscriptionProtocol { get; set; }

        [XmlAttribute("dispatchDate")]
        public DateTime DispatchDate { get; set; }

        [XmlIgnore]
        public bool DispatchDateSpecified { get; set; }

        [XmlAttribute("expiryDate", DataType = "date")]
        public DateTime ExpiryDate { get; set; }

        [XmlIgnore]
        public bool ExpiryDateSpecified { get; set; }

        [XmlAttribute("subscriptionCode")]
        public string SubscriptionCode { get; set; }

        [XmlAttribute]
        public string SubscriptionIdentifier { get; set; }
    }
}
