using System;
using System.Xml.Serialization;

namespace GisGmp.Clarification
{
    /// <summary>
    /// Код платежного документа
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Clarification/2.4.0")]
    public enum AppCode
    {
        /// <summary>
        /// Платежное поручение
        /// </summary>
        PP,

        /// <summary>
        /// Поручение о перечислении на счет
        /// </summary>
        PL,

        /// <summary>
        /// Заявка на кассовый расход
        /// </summary>
        ZR,

        /// <summary>
        /// Сводная заявка на кассовый расход (для уплаты налогов)
        /// </summary>
        ZK,

        /// <summary>
        /// Заявка на получение наличных денег
        /// </summary>
        ZS,

        /// <summary>
        /// Заявка на получение денежных средств, перечисляемых на карту
        /// </summary>
        ZN,

        /// <summary>
        /// Уведомление об уточнении вида и принадлежности платежа
        /// </summary>
        UF,

        /// <summary>
        /// Заявка на возврат
        /// </summary>
        ZV,
    }
}
