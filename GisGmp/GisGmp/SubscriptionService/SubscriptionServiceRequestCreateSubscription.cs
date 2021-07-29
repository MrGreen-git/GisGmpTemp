using GisGmp.Subscription;
using System;
using System.Xml.Serialization;

namespace GisGmp.SubscriptionService
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
    public class SubscriptionServiceRequestCreateSubscription
    {
        [XmlElement("SubscriptionIdentifier", typeof(string), Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.4.0")]
        [XmlElement("SubscriptionCode", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }

        [XmlIgnore]
        public ItemChoiceType2 ItemElementName { get; set; }

        [XmlElement("SubscriptionParameters")]
        public SubscriptionParametersType[] SubscriptionParameters { get; set; }

        [XmlAttribute]
        public SubscriptionServiceRequestCreateSubscriptionSubscriptionStatus subscriptionStatus { get; set; }

        [XmlAttribute]
        public string routingCode { get; set; }
    }
}
