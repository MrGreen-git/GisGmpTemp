using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    [Serializable]
    [XmlType(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0", IncludeInSchema = false)]
    public enum ItemChoiceType2
    {

        [XmlEnum("http://roskazna.ru/gisgmp/xsd/Subscription/2.4.0:SubscriptionIdentifier")]
        SubscriptionIdentifier,

        SubscriptionCode,
    }
}
