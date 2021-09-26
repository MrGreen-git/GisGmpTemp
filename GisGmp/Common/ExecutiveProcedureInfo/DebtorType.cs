using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Тип должника
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public enum DebtorType
    {
        /// <summary>
        /// «1» - юридическое лицо
        /// </summary>
        [XmlEnum("1")]
        Item1,

        /// <summary>
        /// «2» - физическое лицо
        /// </summary>
        [XmlEnum("2")]
        Item2,

        /// <summary>
        /// «3» - индивидуальный предприниматель
        /// </summary>
        [XmlEnum("3")]
        Item3,

        /// <summary>
        /// «1700» - орган, уполномоченный от имени Российской Федерации, субъекта Российской Федерации или муниципального образования осуществлять права и исполнять обязанности в исполнительном производстве
        /// </summary>
        [XmlEnum("1700")]
        Item1700,
    }
}
