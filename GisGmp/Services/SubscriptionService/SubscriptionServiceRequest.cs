using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.SubscriptionService
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0", IsNullable = false)]
    public class SubscriptionServiceRequest : RequestType
    {
        [XmlElement("CreateSubscription", typeof(CreateSubscription))]
        [XmlElement("ExportSubscriptions", typeof(bool))]
        public object Item { get; set; }
    }
}
