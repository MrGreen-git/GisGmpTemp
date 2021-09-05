using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.4.0")]
    public class Subscriptions
    {
        /// <summary />
        protected Subscriptions() { }

        /// <summary />
        public Subscriptions(string subscriptionCode, string subscriptionName, string subscriptionOperation)
        {
            SubscriptionCode = subscriptionCode;
            SubscriptionName = subscriptionName;
            SubscriptionOperation = subscriptionOperation;
        }

        /// <summary />
        public Subscriptions(string subscriptionCode, string subscriptionName, string subscriptionOperation, SubscriptionParameter[] subscriptionParameter)
            : this(subscriptionCode, subscriptionName, subscriptionOperation) => SubscriptionParameter = subscriptionParameter;


        [XmlElement("SubscriptionParameter")]
        public SubscriptionParameter[] SubscriptionParameter
        {
            get => SubscriptionParameterField;
            set => SubscriptionParameterField = Validator.ArrayObj(value: value, name: nameof(SubscriptionParameter), required: false, min: 1, max: 10);
        }

        SubscriptionParameter[] SubscriptionParameterField;


        [XmlAttribute("subscriptionCode")]
        public string SubscriptionCode { get; set; }

        [XmlAttribute("subscriptionName")]
        public string SubscriptionName
        {
            get => SubscriptionNameField;
            set => SubscriptionNameField = Validator.String(value: ref value, name: nameof(SubscriptionName), required: true, min: 0, max: 2000);
        }

        string SubscriptionNameField;


        [XmlAttribute("subscriptionOperation")]
        public string SubscriptionOperation
        {
            get => SubscriptionOperationField;
            set => SubscriptionOperationField = Validator.String(value: ref value, name: nameof(SubscriptionOperation), required: true, min: 0, max: 2000);
        }

        string SubscriptionOperationField;
    }
}
