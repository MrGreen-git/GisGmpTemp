using System;
using System.Xml.Serialization;

namespace GisGmp.CommonNSI
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
    public enum oktmoNSIInfoTypeLastChangeType
    {

        [XmlEnum("1")]
        Item1,

        [XmlEnum("2")]
        Item2,

        [XmlEnum("3")]
        Item3,

        [XmlEnum("0")]
        Item0,
    }
}
