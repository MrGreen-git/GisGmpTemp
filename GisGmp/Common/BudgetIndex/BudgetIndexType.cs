﻿using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Дополнительные реквизиты платежа, предусмотренные приказом Минфина России от 12 ноября 2013 г. №107н
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
    public class BudgetIndexType
    {
        /// <summary>
        /// Поле номер 101: Статус плательщика - реквизит 101 Распоряжения
        /// </summary>
        [XmlAttribute("status")]
        public string Status { get; set; }

        /// <summary>
        /// Поле номер 106: Показатель основания платежа - реквизит 106 Распоряжения
        /// </summary>
        [XmlAttribute("paytReason")]
        public string PaytReason { get; set; }

        /// <summary>
        /// Поле номер 107: Показатель налогового периода или код таможенного органа, осуществляющего в соответствии с законодательством РФ функции по выработке государственной политики и нормативному регулированию, контролю и надзору в области таможенного дела – реквизит 107 Распоряжения.
        /// </summary>
        [XmlAttribute("taxPeriod")]
        public string TaxPeriod { get; set; }

        /// <summary>
        /// Поле номер 108: Показатель номера документа - реквизит 108 Распоряжения
        /// </summary>
        [XmlAttribute("taxDocNumber")]
        public string TaxDocNumber { get; set; }

        /// <summary>
        /// Поле номер 109: Показатель даты документа - реквизит 109 Распоряжения
        /// </summary>
        [XmlAttribute("taxDocDate")]
        public string TaxDocDate { get; set; }
    }
}
