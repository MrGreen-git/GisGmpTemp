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
        [XmlElement("CreateSubscriptionResult", typeof(CreateSubscriptionResult))]
        [XmlElement("Subscriptions", typeof(Subscriptions))]
        public object[] Items { get; set; }


        public CreateSubscriptionResult CreateSubscriptionResult { get; set; }
        public Subscriptions Subscriptions { get; set; }
    }
}
