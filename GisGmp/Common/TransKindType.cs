using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public enum TransKindType
    {

        [XmlEnum("01")]
        Item01,

        [XmlEnum("06")]
        Item06,

        [XmlEnum("16")]
        Item16,
    }
}
