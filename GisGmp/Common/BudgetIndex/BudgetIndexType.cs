using System;
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
        protected BudgetIndexType() { }

        /// <summary>
        /// Дополнительные реквизиты платежа, предусмотренные приказом Минфина России от 12 ноября 2013 г. №107н
        /// </summary>
        /// <param name="status">Поле номер 101: Статус плательщика — реквизит 101 Распоряжения</param>
        /// <param name="paytReason">Поле номер 107: Показатель налогового периода или код таможенного органа, осуществляющего в соответствии с законодательством РФ функции по выработке государственной политики и нормативному регулированию, контролю и надзору в области таможенного дела – реквизит 107 Распоряжения.</param>
        /// <param name="taxPeriod">Поле номер 108: Показатель номера документа – реквизит 108 Распоряжения</param>
        /// <param name="taxDocNumber">Поле номер 108: Показатель номера документа – реквизит 108 Распоряжения</param>
        /// <param name="taxDocDate">Поле номер 109: Показатель даты документа – реквизит 109 Распоряжения</param>
        public BudgetIndexType(string status, string paytReason, string taxPeriod, string taxDocNumber, string taxDocDate)
        {
            Status = status;
            PaytReason = paytReason;
            TaxPeriod = taxPeriod;
            TaxDocNumber = taxDocNumber;
            TaxDocDate = taxDocDate;
        }

        /// <summary>
        /// Поле номер 101: Статус плательщика — реквизит 101 Распоряжения
        /// <para>use: required</para>
        /// <para>length: 0..2</para>
        /// <para>pattern: "\d{2}"</para>
        /// </summary>
        [XmlAttribute("status")]
        public string Status { get; set; } //TODO enum

        /// <summary>
        /// Поле номер 106: Показатель основания платежа — реквизит 106 Распоряжения
        /// <para>use: required</para>
        /// <para>length: 1..2</para>
        /// <para>pattern: "[А-Я]{2}"</para>
        /// <para>pattern: "\d{2}"</para>
        /// <para>pattern: "0"</para>
        /// </summary>
        [XmlAttribute("paytReason")]
        public string PaytReason { get; set; }

        /// <summary>
        /// Поле номер 107: Показатель налогового периода или код таможенного органа, осуществляющего в соответствии с законодательством РФ функции по выработке государственной политики и нормативному регулированию, контролю и надзору в области таможенного дела – реквизит 107 Распоряжения.
        /// <para>use: required</para>
        /// <para>length: 1..10</para>
        /// <para>pattern: "МС\.(0[0-9]|1[012])\.\d{4}"</para>
        /// <para>pattern: "КВ\.0[1-4]\.\d{4}"</para>
        /// <para>pattern: "ПЛ\.0[1-2]\.\d{4}"</para>
        /// <para>pattern: "ГД\.00\.\d{4}"</para>
        /// <para>pattern: "(0[1-9]|[12][0-9]|3[01])\.(0[1-9]|1[012])\.\d{4}"</para>
        /// <para>pattern: "\d{8}"</para>
        /// <para>pattern: "0"</para>
        /// </summary>
        [XmlAttribute("taxPeriod")]
        public string TaxPeriod { get; set; }

        /// <summary>
        /// Поле номер 108: Показатель номера документа – реквизит 108 Распоряжения
        /// <para>use: required</para>
        /// <para>length: 1..15</para>
        /// </summary>
        [XmlAttribute("taxDocNumber")]
        public string TaxDocNumber { get; set; }

        /// <summary>
        /// Поле номер 109: Показатель даты документа – реквизит 109 Распоряжения
        /// <para>use: required</para>
        /// <para>length: 1..n</para>
        /// <para>pattern: "(0[1-9]|[12][0-9]|3[01])\.(0[1-9]|1[012])\.\d{4}"</para>
        /// <para>pattern: "00"</para>
        /// <para>pattern: "0"</para>
        /// </summary>
        [XmlAttribute("taxDocDate")]
        public string TaxDocDate { get; set; }
    }
}
