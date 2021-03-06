using System;
using System.Xml.Serialization;

namespace GisGmp.NoticeCharge
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/NoticeCharge/2.4.0")]
    public enum NoticeChargeTypeEventNotification
    {

        [XmlEnum("1")]
        Item1,

        [XmlEnum("2")]
        Item2,

        [XmlEnum("3")]
        Item3,

        [XmlEnum("4")]
        Item4,

        [XmlEnum("5")]
        Item5,

        [XmlEnum("6")]
        Item6,
    }
}
