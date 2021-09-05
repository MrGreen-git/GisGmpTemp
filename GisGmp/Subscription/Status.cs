using System;
using System.Xml.Serialization;

namespace GisGmp.Subscription
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.4.0")]
    public enum Status
    {

        [XmlEnum("1")]
        Item1,

        [XmlEnum("2")]
        Item2,
    }
}
