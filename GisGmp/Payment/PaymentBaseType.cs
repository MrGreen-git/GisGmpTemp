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
        /// <summary/>
        protected PaymentBaseType() { }

        public PaymentBaseType(
            PaymentOrgType paymentOrg,
            Payee payee,
            string purpose,
            ulong amount,
            TransKindType transKind
            ) 
        { 
            PaymentOrg = paymentOrg;
            Payee = payee;
            Purpose = purpose;
            Amount = amount;
            TransKind = transKind;
        }

        /// <summary>
        /// Данные организации, принявшей платеж | required
        /// </summary>
        public PaymentOrgType PaymentOrg { get; set; }

        /// <summary>
        /// Поле номер 2006: Сведения о плательщике | not required
        /// </summary>
        public PaymentPayer Payer { get; set; }

        /// <summary>
        /// Сведения о получателе средств | required
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
        public Payee Payee { get; set; }

        /// <summary>
        /// Поле номер 2007 Реквизиты платежа 101, 106-109 | not required
        /// </summary>
        public BudgetIndexType BudgetIndex { get; set; }

        /// <summary>
        /// Поле номер 2008 Реквизиты платежного документа | not required
        /// </summary>
        public AccDocType AccDoc { get; set; }

        /// <summary>
        /// Поле номер 202: Дополнительные поля платежа | not required
        /// </summary>
        [XmlElement("AdditionalData", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public AdditionalDataType[] AdditionalData { get; set; }

        /// <summary>
        /// Поле номер 1000: УИН | not required
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }

        /// <summary>
        /// Поле номер 24: Назначение платежа | required
        /// </summary>
        [XmlAttribute("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Поле номер 7: Сумма платежа | required 
        /// </summary>
        [XmlAttribute("amount")]
        public ulong Amount { get => AmountField; set => AmountField = value; }

        ulong AmountField;

        /// <summary>
        /// Поле номер 62: Дата поступления распоряжения в банк плательщика | not required
        /// </summary>
        [XmlAttribute(DataType = "date")]
        public DateTime receiptDate { get; set; }

        [XmlIgnore]
        public bool receiptDateSpecified { get; set; }

        /// <summary>
        /// Поле номер 2063: Дата исполнения распоряжения о переводе денежных средств после осуществления контроля достаточности денежных средств на банковском счете плательщика для исполнения распоряжения.
        /// not required
        /// </summary>
        [XmlAttribute(DataType = "date")]
        public DateTime paymentExecDate { get; set; }

        [XmlIgnore]
        public bool paymentExecDateSpecified { get; set; }

        /// <summary>
        /// Поле номер 104: КБК | not required
        /// </summary>
        [XmlAttribute("kbk")]
        public string Kbk { get; set; }

        /// <summary>
        /// Поле номер 105: Код по ОКТМО, указанный в распоряжении о переводе денежных средств | not required
        /// </summary>
        [XmlAttribute("oktmo")]
        public string Oktmo { get; set; }

        /// <summary>
        /// Поле номер 18: Вид операции | required
        /// </summary>
        [XmlAttribute("transKind")]
        public TransKindType TransKind { get; set; }
    }
}
