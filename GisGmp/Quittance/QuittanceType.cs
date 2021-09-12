using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Quittance
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Quittance/2.4.0")]
    public class QuittanceType
    {
        /// <summary/>
        protected QuittanceType() { }

        /// <summary/>
        public QuittanceType(
            string supplierBillID,
            DateTime creationDate,
            AcknowledgmentStatusType billStatus,
            string paymentId
            )
        {
            SupplierBillID = supplierBillID;
            CreationDate = creationDate;
            BillStatus = billStatus;
            PaymentId = paymentId;
        }

        /// <summary>
        /// Дополнительные условия оплаты | not required
        /// </summary>
        [XmlElement("DiscountFixed", typeof(DiscountFixed), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("DiscountSize", typeof(DiscountSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("MultiplierSize", typeof(MultiplierSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public DiscountType Item { get; set; }

        /// <summary>
        /// Условия оплаты с фиксированной суммой скидки
        /// </summary>
        [XmlIgnore]
        public DiscountFixed DiscountFixed 
        {
            get => Item as DiscountFixed;
            set => Item = value;
        }

        /// <summary>
        /// Условия оплаты со скидкой (процент)
        /// </summary>
        [XmlIgnore]
        public DiscountSize DiscountSize
        {
            get => Item as DiscountSize;
            set => Item = value;
        }

        /// <summary>
        /// Условия оплаты с применением понижающего размер коэффициента
        /// </summary>
        [XmlIgnore]
        public MultiplierSize MultiplierSize
        {
            get => Item as MultiplierSize;
            set => Item = value;
        }

        /// <summary>
        /// Сведения о возврате денежных средств | not required
        /// </summary>
        [XmlElement("Refund")]
        public Refund[] Refund { get; set; }

        /// <summary>
        /// УИН | required
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }

        /// <summary>
        /// Сумма, указанная в начислении | not required
        /// </summary>
        [XmlAttribute("totalAmount")]
        public ulong TotalAmount { get; set; }

        [XmlIgnore]
        public bool TotalAmountSpecified { get; set; }

        /// <summary>
        /// Дата квитирования (создания квитанции) | required
        /// </summary>
        [XmlAttribute("creationDate")]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Статус, присвоенный начислению при создании квитанции | required
        /// </summary>
        [XmlAttribute("billStatus")]
        public AcknowledgmentStatusType BillStatus { get; set; }

        /// <summary>
        /// Разность между суммой, указанной в начислении, и суммой платежей с учетом возвратов | not required
        /// </summary>
        [XmlAttribute]
        public long Balance { get; set; }

        [XmlIgnore]
        public bool BalanceSpecified { get; set; }

        /// <summary>
        /// УПНО, присвоенный участником, принявшим платеж | required
        /// </summary>
        [XmlAttribute("paymentId")]
        public string PaymentId { get; set; }

        /// <summary>
        /// Сумма, указанная в платеже | not required
        /// </summary>
        [XmlAttribute("amountPayment")]
        public ulong AmountPayment { get; set; }

        [XmlIgnore]
        public bool AmountPaymentSpecified { get; set; }

        /// <summary>
        /// ИНН получателя средств | not required
        /// </summary>
        [XmlAttribute("payeeINN")]
        public string PayeeINN { get; set; }

        /// <summary>
        /// КПП получателя средств | not required
        /// </summary>
        [XmlAttribute("payeeKPP")]
        public string PayeeKPP { get; set; }

        /// <summary>
        /// КБК | not required
        /// </summary>
        [XmlAttribute("kbk")]
        public string Kbk { get; set; }

        /// <summary>
        /// Код ОКТМО | not required
        /// </summary>
        [XmlAttribute("oktmo")]
        public string Oktmo { get; set; }

        /// <summary>
        /// Идентификатор плательщика | not required
        /// </summary>
        [XmlAttribute("payerIdentifier")]
        public string PayerIdentifier { get; set; }

        /// <summary>
        /// Номер счета получателя средств | not required
        /// </summary>
        [XmlAttribute("accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// БИК структурного подразделения кредитной организации или подразделения Банка России, в котором открыт счет | not required
        /// </summary>
        [XmlAttribute("bik")]
        public string Bik { get; set; }

        /// <summary>
        /// Признак аннулирования квитанции | not required
        /// </summary>
        [XmlAttribute("isRevoked")]
        public bool IsRevoked { get; set; }

        [XmlIgnore]
        public bool IsRevokedSpecified { get; set; }

        /// <summary>
        /// Признак уплаты с использованием ЕПГУ, РПГУ и иных порталов, интегрированных с ЕСИА | not required
        /// </summary>
        [XmlAttribute("paymentPortal")]
        public bool PaymentPortal { get; set; }

        [XmlIgnore]
        public bool PaymentPortalSpecified { get; set; }
    }
}
