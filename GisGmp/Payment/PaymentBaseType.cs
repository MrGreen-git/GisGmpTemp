using GisGmp.Common;
using GisGmp.Income;
using GisGmp.Organization;
using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Payment
{
    [XmlInclude(typeof(PaymentType))]
    [XmlInclude(typeof(ImportedPaymentType))]
    [XmlInclude(typeof(IncomeType))]
    [XmlInclude(typeof(ImportedIncomeType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.4.0")]
    public class PaymentBaseType
    {
        protected PaymentBaseType() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="purpose">Поле номер 24: Назначение платежа</param>
        /// <param name="amount">Поле номер 7: Сумма платежа</param>
        /// <param name="transKind">Поле номер 18: Вид операции</param>
        /// <param name="paymentOrg">Данные организации, принявшей платеж</param>
        /// <param name="payee">Сведения о получателе средств</param>
        /// <param name="budgetIndex">Поле номер 2007 Реквизиты платежа 101, 106-109</param>
        public PaymentBaseType(
            string purpose,
            ulong amount,
            TransKindType transKind,
            PaymentOrgType paymentOrg,
            Payee payee,
            BudgetIndexType budgetIndex
            ) 
        {
            Purpose = purpose;
            Amount = amount;
            TransKind = transKind;
            PaymentOrg = paymentOrg;
            Payee = payee;          
            BudgetIndex = budgetIndex;          
        }


        /// <summary>
        /// Поле номер 1000: УИН
        /// <para>use: not required</para>
        /// <para>type: com:SupplierBillIDType</para>
        /// <para>pattern: "\d{15}"</para>
        /// <para>pattern: "0"</para>
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID //TODO type
        {
            get => SupplierBillIDField;
            set => SupplierBillIDField = value.IsRequired();
        }

        string SupplierBillIDField;

        /// <summary>
        /// Поле номер 24: Назначение платежа
        /// <para>use: required</para>
        /// <para>length: 0..210</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("purpose")]
        public string Purpose 
        {
            get => PurposeField;
            set => PurposeField = value.IsRequired().IsLength(min: 0, max: 210);
        }

        string PurposeField;

        /// <summary>
        /// Поле номер 7: Сумма платежа
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("amount")]
        public ulong Amount { get; set; }

        /// <summary>
        /// Поле номер 62: Дата поступления распоряжения в банк плательщика
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("receiptDate", DataType = "date")]
        public DateTime ReceiptDate { get; set; }

        [XmlIgnore]
        public bool ReceiptDateSpecified { get; set; }

        /// <summary>
        /// Поле номер 2063: Дата исполнения распоряжения о переводе денежных средств после осуществления контроля достаточности денежных средств на банковском счете плательщика для исполнения распоряжения.
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("paymentExecDate", DataType = "date")]
        public DateTime PaymentExecDate { get; set; }

        [XmlIgnore]
        public bool PaymentExecDateSpecified { get; set; }

        /// <summary>
        /// Поле номер 104: КБК
        /// <para>use: not required</para>
        /// <para>type: com:KBKType</para>
        /// <para>pattern: "[0-9a-zA-Zа-яА-Я]{20}"</para>
        /// <para>pattern: "0"</para>
        /// </summary>
        [XmlAttribute("kbk")]
        public string Kbk { get; set; }

        /// <summary>
        /// Поле номер 105: Код по ОКТМО, указанный в распоряжении о переводе денежных средств
        /// <para>use: not required</para>
        /// <para>type: com:OKTMOType</para>
        /// <para>length: 1..11</para>
        /// <para>pattern: "\d{8}"</para>
        /// <para>pattern: "\d{11}"</para>
        /// </summary>
        [XmlAttribute("oktmo")]
        public string Oktmo { get; set; } //TODO type

        /// <summary>
        /// Поле номер 18: Вид операции
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("transKind")]
        public TransKindType TransKind { get; set; }

        /// <summary>
        /// Данные организации, принявшей платеж
        /// <para>use: required</para>
        /// </summary>
        public PaymentOrgType PaymentOrg 
        { 
            get => PaymentOrgField;
            set => PaymentOrgField = value.IsRequired();
        }

        PaymentOrgType PaymentOrgField;

        /// <summary>
        /// Поле номер 2006: Сведения о плательщике
        /// <para>use: not required</para>
        /// </summary>
        public PaymentPayer Payer { get; set; }

        /// <summary>
        /// Сведения о получателе средств
        /// <para>use: required</para>
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
        public Payee Payee 
        { 
            get => PayeeField;
            set => PayeeField = value.IsRequired();
        }

        Payee PayeeField;

        /// <summary>
        /// Поле номер 2007 Реквизиты платежа 101, 106-109
        /// <para>use: required</para>
        /// </summary>
        public BudgetIndexType BudgetIndex 
        { 
            get => BudgetIndexField;
            set => BudgetIndexField = value.IsRequired();
        }

        BudgetIndexType BudgetIndexField;

        /// <summary>
        /// Поле номер 2008 Реквизиты платежного документа
        /// <para>use: not required</para>
        /// </summary>
        public AccDocType AccDoc { get; set; }

        /// <summary>
        /// Поле номер 202: Дополнительные поля платежа
        /// <para>use: not required</para>
        /// <para>range: 0..10</para>
        /// </summary>
        [XmlElement("AdditionalData", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public AdditionalDataType[] AdditionalData 
        { 
            get => AdditionalDataField;
            set => AdditionalDataField = value.IsRange(min: 0, max: 10);
        }

        AdditionalDataType[] AdditionalDataField;
    }
}
