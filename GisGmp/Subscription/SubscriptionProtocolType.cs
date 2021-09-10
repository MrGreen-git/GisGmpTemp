using System;
using System.Xml.Serialization;

namespace GisGmp.Subscription
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.4.0")]
    public class SubscriptionProtocolType
    {
        /// <summary />
        protected SubscriptionProtocolType() { }

        /// <summary />
        public SubscriptionProtocolType(string code, string description)
        {
            Code = code;
            Description = description;
        }

        /// <summary />
        public SubscriptionProtocolType(string code, string description, string parameterId)
            : this(code, description) => ParameterId = parameterId;


        [XmlAttribute("parameterId", DataType = "ID")]
        public string ParameterId { get; set; }

        [XmlAttribute("code")]
        public string Code { get; set; }

        [XmlAttribute("description")]
        public string Description { get; set; }
    }
}
