using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Package;
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
        /// <summary/>
        protected IncomeType() { }

        /// <summary/>
        public IncomeType(IncomeType income) => Clone.Field(this, income);


        public IncomeType(
            PaymentOrgType paymentOrg,
            Payee payee,
            string purpose,
            ulong amount,
            TransKindType transKind,
            string incomeId,
            DateTime incomeDate,
            EdCode edCode,
            string edNo,
            DateTime edDate,
            string isUncertain
            ) : base (paymentOrg, payee, purpose, amount, transKind)
        {
            IncomeId = incomeId;
            IncomeDate = incomeDate;
            EdCode = edCode;
            EdNo = edNo;
            EdDate = edDate;
            IsUncertain = isUncertain;
        }

        /// <summary>
        /// Поле 4010: Реквизиты зачисления после обработки и классификации кредитовых распоряжений | not required
        /// </summary>
        public IncomeIndex IncomeIndex { get; set; }

        /// <summary>
        /// Поле номер 4004: Номер записи в реестре | not required
        /// </summary>
        [XmlAttribute("transactionID")]
        public string TransactionID { get; set; }

        /// <summary>
        /// Поле номер 4005: Дата составления электронного сообщения
        /// required ?
        /// </summary>
        [XmlAttribute("edDate", DataType = "date")]
        public DateTime EdDate { get; set; }

        /// <summary>
        /// Уникальный идентификатор зачисления (УИЗ) | required
        /// </summary>
        [XmlAttribute("incomeId")]
        public string IncomeId { get; set; }

        /// <summary>
        /// Поле номер 4001: Дата и время формирования зачисления | reqiured
        /// </summary>
        [XmlAttribute("incomeDate")]
        public DateTime IncomeDate { get; set; }

        /// <summary>
        /// Поле номер 4002: Обозначение электронного сообщения в унифицированных форматах электронных банковских сообщений Банка России, на основании которого сформировано зачисление
        /// required
        /// </summary>
        [XmlAttribute("edCode")]
        public EdCode EdCode { get; set; }

        /// <summary>
        /// Поле номер 4200: Номер электронного сообщения в течение опердня
        /// required
        /// </summary>
        [XmlAttribute("edNo")]
        public string EdNo { get; set; }

        /// <summary>
        /// Поле номер 71: Дата списания денежных средств со счета плательщика | not required
        /// </summary>
        [XmlAttribute("chargeOffDate", DataType = "date")]
        public DateTime ChargeOffDate { get; set; }

        [XmlIgnore]
        public bool ChargeOffDateSpecified { get; set; }

        /// <summary>
        /// Поле номер 4003: Признак отнесения платежа к невыясненным | required
        /// </summary>
        [XmlAttribute("isUncertain")]
        public string IsUncertain { get; set; }

        /// <summary>
        /// Поле номер 2000:УПНО(УИП) | not required
        /// </summary>
        [XmlAttribute("paymentId")]
        public string PaymentId { get; set; }
    }
}
