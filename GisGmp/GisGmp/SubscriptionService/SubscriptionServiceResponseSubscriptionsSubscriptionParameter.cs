using System;
using System.Xml.Serialization;

namespace GisGmp.SubscriptionService
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
    public class SubscriptionServiceResponseSubscriptionsSubscriptionParameter
    {
        [XmlAttribute]
        public string parameterCode { get; set; }

        [XmlAttribute]
        public string parameterName { get; set; }

        [XmlAttribute]
        public string parameterPattern { get; set; }

        [XmlAttribute]
        public bool required { get; set; }

        [XmlAttribute]
        public string parameterDescription { get; set; }
    }
}
