using System;
using System.Xml.Serialization;

namespace GisGmp.Renouncement
{
    /// <summary>
    /// Код причины отказа (пункт ч. 1 ст. 31 Федерального закона от 02.10.2007 N 229-ФЗ)
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Renouncement/2.4.0")]
    public enum ReasonCode
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
