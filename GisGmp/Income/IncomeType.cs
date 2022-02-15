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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="purpose">Поле номер 24: Назначение платежа</param>
        /// <param name="amount">Поле номер 7: Сумма платежа</param>
        /// <param name="transKind">Поле номер 18: Вид операции</param>
        /// <param name="paymentOrg">Данные организации, принявшей платеж</param>
        /// <param name="payee">Сведения о получателе средств</param>
        /// <param name="budgetIndex">Поле номер 2007 Реквизиты платежа 101, 106-109</param>
        /// <param name="incomeId">Уникальный идентификатор зачисления (УИЗ)</param>
        /// <param name="incomeDate">Поле номер 4001: Дата и время формирования зачисления</param>
        /// <param name="edCode">Поле номер 4002: Обозначение электронного сообщения в унифицированных форматах электронных банковских сообщений Банка России, на основании которого сформировано зачисление</param>
        /// <param name="edNo">Поле номер 4200: Номер электронного сообщения в течение опердня</param>
        /// <param name="edDate">Поле номер 4005: Дата составления электронного сообщения</param>
        /// <param name="isUncertain">Поле номер 4003: Признак отнесения платежа к невыясненным</param>
        public IncomeType(
            string purpose,
            ulong amount,
            TransKindType transKind,
            PaymentOrgType paymentOrg,
            Payee payee,
            BudgetIndexType budgetIndex,
            string incomeId,
            DateTime incomeDate,
            EdCode edCode,
            string edNo,
            DateTime edDate,
            string isUncertain
            ) : base(purpose, amount, transKind, paymentOrg, payee, budgetIndex)
        {
            IncomeId = incomeId;
            IncomeDate = incomeDate;
            EdCode = edCode;
            EdNo = edNo;
            EdDate = edDate;
            IsUncertain = isUncertain;
        }

        /// <summary>
        /// Уникальный идентификатор зачисления (УИЗ)
        /// <para>use: required</para>
        /// <para>type: com:IncomeIdType</para>
        /// <para>pattern: "4\d{4}((0[1-9]|[12][0-9]|3[01])(0[1-9]|1[012])\d{4})\d{19}"</para>
        /// </summary>
        [XmlAttribute("incomeId")]
        public string IncomeId { get; set; } //TODO type

        /// <summary>
        /// Поле номер 4001: Дата и время формирования зачисления
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("incomeDate")]
        public DateTime IncomeDate { get; set; }

        /// <summary>
        /// Поле номер 4002: Обозначение электронного сообщения в унифицированных форматах электронных банковских сообщений Банка России, на основании которого сформировано зачисление
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("edCode")]
        public EdCode EdCode { get; set; }

        /// <summary>
        /// Поле номер 4200: Номер электронного сообщения в течение опердня
        /// <para>use: required</para>
        /// <para> length: 0..9</para>
        /// </summary>
        [XmlAttribute("edNo")]
        public string EdNo 
        {
            get => EdNoField;
            set => EdNoField = value.IsRequired().IsLength(min: 0, max: 9);
        }

        string EdNoField;

        /// <summary>
        /// Поле номер 4005: Дата составления электронного сообщения
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("edDate", DataType = "date")]
        public DateTime EdDate { get; set; }

        /// <summary>
        /// Поле номер 4004: Номер записи в реестре
        /// <para>use: not required</para>
        /// <para>length: 0..5</para>
        /// </summary>
        [XmlAttribute("transactionID")]
        public string TransactionID 
        {
            get => TransactionIDField;
            set => TransactionIDField = value.IsLength(min: 0, max: 5);
        }

        string TransactionIDField;

        /// <summary>
        /// Поле номер 71: Дата списания денежных средств со счета плательщика
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("chargeOffDate", DataType = "date")]
        public DateTime ChargeOffDate { get; set; }

        [XmlIgnore]
        public bool ChargeOffDateSpecified { get; set; }

        /// <summary>
        /// Поле номер 4003: Признак отнесения платежа к невыясненным
        /// <para>use: required</para>
        /// <para>pattern: "0"</para> //0 – для остальных зачислений
        /// <para>pattern: "1"</para> //1 – для невыясненных поступлений
        /// </summary>
        [XmlAttribute("isUncertain")]
        public string IsUncertain 
        {
            get => IsUncertainField;
            set => IsUncertainField = value.IsRequired().IsLength(min: 1, max: 1);
        }

        string IsUncertainField;

        /// <summary>
        /// Поле 4010: Реквизиты зачисления после обработки и классификации кредитовых распоряжений
        /// <para>use: not required</para>
        /// </summary>
        public IncomeIndex IncomeIndex { get; set; }

        /// <summary>
        /// Поле номер 2000:УПНО(УИП)
        /// <para>use: not required</para>
        /// <para>type: com:PaymentIdType</para>
        /// <para>pattern: "1\d{15}((0[1-9]|[12][0-9]|3[01])(0[1-9]|1[012])\d{4})\d{8}"</para>
        /// <para>pattern: "2\d{4}0{11}((0[1-9]|[12][0-9]|3[01])(0[1-9]|1[012])\d{4})\d{8}"</para>
        /// <para>pattern: "3[a-fA-F0-9]{6}((0[1-9]|[12][0-9]|3[01])(0[1-9]|1[012])\d{4})\d{17}"</para>
        /// <para>pattern: "\w{32}"</para>
        /// </summary>
        [XmlAttribute("paymentId")]
        public string PaymentId { get; set; } //TODO type
    }
}
