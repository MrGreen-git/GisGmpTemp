using GisGmp.Subscription;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
    public class CreateSubscription
    {
        /// <summary />
        protected CreateSubscription() { }

        /// <summary />
        public CreateSubscription(SubscriptionStatus subscriptionStatus, ItemChoiceType2 itemElementName, string item)
        {
            SubscriptionStatus = subscriptionStatus;
            ItemElementName = itemElementName;
            Item = item;
        }

        [XmlElement("SubscriptionIdentifier", typeof(string), Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.4.0")]
        [XmlElement("SubscriptionCode", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }

        [XmlIgnore]
        public ItemChoiceType2 ItemElementName { get; set; }

        [XmlElement("SubscriptionParameters")]
        public SubscriptionParametersType[] SubscriptionParameters
        {
            get => SubscriptionParametersField;
            set => SubscriptionParametersField = Validator.ArrayObj(value: value, name: nameof(SubscriptionParameters), required: false, min: 1, max: 250);
        }

        SubscriptionParametersType[] SubscriptionParametersField;

        [XmlAttribute("subscriptionStatus")]
        public SubscriptionStatus SubscriptionStatus { get; set; }

        [XmlAttribute("routingCode")]
        public string RoutingCode { get; set; }
    }
}
