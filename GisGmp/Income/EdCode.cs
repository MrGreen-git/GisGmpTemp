using System;
using System.Xml.Serialization;

namespace GisGmp.Income
{
    /// <summary>
    /// Поле номер 4002: Обозначение электронного сообщения в унифицированных форматах электронных банковских сообщений Банка России, на основании которого сформировано зачисление
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Income/2.4.0")]
    public enum EdCode
    {
        /// <summary>
        /// ED101 – Платежное поручение
        /// </summary>
        ED101,

        /// <summary>
        /// ED104 – Инкассовое поручение
        /// </summary>
        ED104,

        /// <summary>
        /// ED105 – Платежный ордер
        /// </summary>
        ED105,

        /// <summary>
        /// ED108 – Платежное поручение на общую сумму с реестром
        /// </summary>
        ED108,

        /// <summary>
        /// ED701 – Поручение для СБП
        /// </summary>
        ED701,
    }
}
