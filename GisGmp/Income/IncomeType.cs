﻿using GisGmp.Package;
using GisGmp.Payment;
using System;
using System.Xml.Serialization;

namespace GisGmp.Income
{
    [XmlInclude(typeof(ImportedIncomeType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Income/2.4.0")]
    public class IncomeType : PaymentBaseType
    {
        /// <summary>
        /// Поле 4010: Реквизиты зачисления после обработки и классификации кредитовых распоряжений
        /// </summary>
        public IncomeIndex IncomeIndex { get; set; }

        /// <summary>
        /// Поле номер 4004:Номер записи в реестре
        /// </summary>
        [XmlAttribute("transactionID")]
        public string TransactionID { get; set; }

        /// <summary>
        /// Поле номер 4005: Дата составления электронного сообщения
        /// </summary>
        [XmlAttribute("edDate", DataType = "date")]
        public DateTime EdDate { get; set; }

        /// <summary>
        /// Уникальный идентификатор зачисления
        /// </summary>
        [XmlAttribute("incomeId")]
        public string IncomeId { get; set; }

        /// <summary>
        /// Поле номер 4001: Дата и время формирования документа
        /// </summary>
        [XmlAttribute("incomeDate")]
        public DateTime IncomeDate { get; set; }

        /// <summary>
        /// Поле номер 4002: Обозначение электронного сообщения в унифицированных форматах электронных банковских сообщений Банка России, на основании которого сформировано зачисление
        /// </summary>
        [XmlAttribute("edCode")]
        public EdCode EdCode { get; set; }

        /// <summary>
        /// Поле номер 4200: Номер электронного сообщения в течение опердня
        /// </summary>
        [XmlAttribute("edNo")]
        public string EdNo { get; set; }

        /// <summary>
        /// Поле номер 71: Дата списания денежных средств со счета плательщика
        /// </summary>
        [XmlAttribute("chargeOffDate", DataType = "date")]
        public DateTime ChargeOffDate { get; set; }

        [XmlIgnore]
        public bool ChargeOffDateSpecified { get; set; }

        /// <summary>
        /// Поле номер 4003: Признак отнесения платежа к невыясненным
        /// </summary>
        [XmlAttribute("isUncertain")]
        public bool IsUncertain { get; set; }

        /// <summary>
        /// Поле номер 2000:УПНО(УИП)
        /// </summary>
        [XmlAttribute("paymentId")]
        public string PaymentId { get; set; }
    }
}
