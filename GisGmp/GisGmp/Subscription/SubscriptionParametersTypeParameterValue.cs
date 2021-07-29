using System;
using System.Xml.Serialization;

namespace GisGmp.Subscription
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.4.0")]
    public class SubscriptionParametersTypeParameterValue
    {
        [XmlAttribute]
        public string parameterCode { get; set; }

        [XmlText()]
        public string Value { get; set; }
    }
}
