using System;
using System.Xml.Serialization;

namespace GisGmp.Renouncement
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Renouncement/2.4.0")]
    public enum RenouncementTypeReasonCode
    {

        [XmlEnum("3")]
        Item3,

        [XmlEnum("4")]
        Item4,

        [XmlEnum("7")]
        Item7,

        [XmlEnum("8")]
        Item8,
    }
}
