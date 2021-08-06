using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Статус, присваиваемый начислению при создании квитанции
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public enum AcknowledgmentStatusType
    {
        /// <summary>
        /// 1 - сквитировано
        /// </summary>
        [XmlEnum("1")]
        Item1,

        /// <summary>
        /// 2 - предварительно сквитировано
        /// </summary>
        [XmlEnum("2")]
        Item2,

        /// <summary>
        /// 3 - не сквитировано
        /// </summary>
        [XmlEnum("3")]
        Item3,

        /// <summary>
        /// 4 - сквитировано по инициативе АН/ГАН с отсутствующим в ГИС ГМП платежом
        /// </summary>
        [XmlEnum("4")]
        Item4,

        /// <summary>
        /// 5 - принудительно сквитировано по инициативе АН/ГАН с платежом
        /// </summary>
        [XmlEnum("5")]
        Item5,

        /// <summary>
        /// 6 – сквитировано с отсутствующим в системе платежом с указанием суммы
        /// </summary>
        [XmlEnum("6")]
        Item6,
    }
}
