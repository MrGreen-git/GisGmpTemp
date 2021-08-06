using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Поле номер 1106: Тип периода срока предъявления исполнительного документа
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public enum SrokPrIspType
    {

        [XmlEnum("1")]
        Item1,

        [XmlEnum("2")]
        Item2,

        [XmlEnum("3")]
        Item3,
    }
}
