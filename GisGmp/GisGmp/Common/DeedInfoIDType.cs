using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public enum DeedInfoIDType
    {

        [XmlEnum("1")]
        Item1,

        [XmlEnum("3")]
        Item3,

        [XmlEnum("4")]
        Item4,

        [XmlEnum("5")]
        Item5,

        [XmlEnum("7")]
        Item7,

        [XmlEnum("10")]
        Item10,

        [XmlEnum("11")]
        Item11,

        [XmlEnum("13")]
        Item13,

        [XmlEnum("16")]
        Item16,
    }
}
