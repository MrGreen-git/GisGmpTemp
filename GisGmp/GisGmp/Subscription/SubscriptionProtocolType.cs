using System;
using System.Xml.Serialization;

namespace GisGmp.Subscription
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.4.0")]
    public class SubscriptionProtocolType
    {
        [XmlAttribute(DataType = "ID")]
        public string parameterId { get; set; }

        [XmlAttribute]
        public string code { get; set; }

        [XmlAttribute]
        public string description { get; set; }
    }
}
