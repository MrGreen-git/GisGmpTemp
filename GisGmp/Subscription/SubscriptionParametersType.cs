using System;
using System.Xml.Serialization;

namespace GisGmp.Subscription
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.4.0")]
    public class SubscriptionParametersType
    {
        [XmlElement("ParameterValue")]
        public SubscriptionParametersTypeParameterValue[] ParameterValue { get; set; }

        [XmlAttribute]
        public SubscriptionParametersTypeStatus status { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string parameterId { get; set; }
    }
}
