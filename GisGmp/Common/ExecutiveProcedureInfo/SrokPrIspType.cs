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
        /// <summary>
        /// "1" - день
        /// </summary>
        [XmlEnum("1")]
        Item1,

        /// <summary>
        /// "2" - месяц
        /// </summary>
        [XmlEnum("2")]
        Item2,

        /// <summary>
        /// "3" - год
        /// </summary>
        [XmlEnum("3")]
        Item3,
    }
}
