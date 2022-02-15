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
        /// PP - Платежное поручение
        /// </summary>
        PP,

        /// <summary>
        /// PL - Поручение о перечислении на счет
        /// </summary>
        PL,

        /// <summary>
        /// ZR - Заявка на кассовый расход
        /// </summary>
        ZR,

        /// <summary>
        /// ZK - Сводная заявка на кассовый расход (для уплаты налогов)
        /// </summary>
        ZK,

        /// <summary>
        /// ZS - Заявка на получение наличных денег
        /// </summary>
        ZS,

        /// <summary>
        /// ZN - Заявка на получение денежных средств, перечисляемых на карту
        /// </summary>
        ZN,

        /// <summary>
        /// UF - Уведомление об уточнении вида и принадлежности платежа
        /// </summary>
        UF,

        /// <summary>
        /// ZV - Заявка на возврат
        /// </summary>
        ZV,
    }
}
