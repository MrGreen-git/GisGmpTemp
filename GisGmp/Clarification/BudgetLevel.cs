using System;
using System.Xml.Serialization;

namespace GisGmp.Clarification
{
    /// <summary>
    /// Уровень бюджета
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
    public enum BudgetLevel
    {
        /// <summary>
        /// 1 – «федеральный»
        /// </summary>
        [XmlEnum("1")]
        Item1,

        /// <summary>
        /// 2 – «бюджет субъекта РФ»
        /// </summary>
        [XmlEnum("2")]
        Item2,

        /// <summary>
        /// 3 – «местный бюджет»
        /// </summary>
        [XmlEnum("3")]
        Item3,

        /// <summary>
        /// 4 – «бюджет ГВФ РФ»
        /// </summary>
        [XmlEnum("4")]
        Item4,

        /// <summary>
        /// 5 – «бюджет ТГВФ РФ»
        /// </summary>
        [XmlEnum("5")]
        Item5,

        /// <summary>
        /// 6 – «средства ЮЛ»
        /// </summary>
        [XmlEnum("6")]
        Item6,
    }
}
