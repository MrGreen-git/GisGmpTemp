using System;
using System.Xml.Serialization;

namespace GisGmp.Subscription
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.4.0")]
    public class SubscriptionParametersType
    {
        /// <summary />
        protected SubscriptionParametersType() { }

        /// <summary />
        public SubscriptionParametersType(Status status, string parameterId, ParameterValue[] parameterValue)
        {
            Status = status;
            ParameterId = parameterId;
            ParameterValue = parameterValue;
        }

        [XmlElement("ParameterValue")]
        public ParameterValue[] ParameterValue { get; set; }

        [XmlAttribute("status")]
        public Status Status { get; set; }

        [XmlAttribute("parameterId", DataType = "ID")]
        public string ParameterId { get; set; }
    }
}
