using System;
using System.Xml.Serialization;

namespace GisGmp.Common.NSI
{
    /// <summary>
    /// Тип изменения
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.4.0")]
    public enum LastChangeType
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
