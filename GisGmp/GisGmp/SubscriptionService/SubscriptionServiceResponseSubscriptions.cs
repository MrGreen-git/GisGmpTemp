using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GisGmp.SubscriptionService
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
    public class SubscriptionServiceResponseSubscriptions
    {
        [XmlElement("SubscriptionParameter")]
        public SubscriptionServiceResponseSubscriptionsSubscriptionParameter[] SubscriptionParameter { get; set; }

        [XmlAttribute]
        public string subscriptionCode { get; set; }

        [XmlAttribute]
        public string subscriptionName { get; set; }

        [XmlAttribute]
        public string subscriptionOperation { get; set; }
    }
}
