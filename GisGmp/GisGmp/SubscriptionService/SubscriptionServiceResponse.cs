using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.SubscriptionService
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0", IsNullable = false)]
    public class SubscriptionServiceResponse : ResponseType
    {
        [XmlElement("CreateSubscriptionResult", typeof(SubscriptionServiceResponseCreateSubscriptionResult))]
        [XmlElement("Subscriptions", typeof(SubscriptionServiceResponseSubscriptions))]
        public object[] Items { get; set; }
    }
}
