using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Quittance
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Quittance/2.4.0")]
    public class QuittanceType
    {
        protected QuittanceType() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="supplierBillID">УИН</param>
        /// <param name="creationDate">Дата квитирования (создания квитанции)</param>
        /// <param name="billStatus">Статус, присвоенный начислению при создании квитанции</param>
        /// <param name="paymentId">УПНО, присвоенный участником, принявшим платеж</param>
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
        /// УИН
        /// <para>use: required</para>
        /// <para>type: com:SupplierBillIDType</para>
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; } //TODO type

        /// <summary>
        /// Сумма, указанная в начислении
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("totalAmount")]
        public ulong TotalAmount { get; set; }

        [XmlIgnore]
        public bool TotalAmountSpecified { get; set; }

        /// <summary>
        /// Дата квитирования (создания квитанции)
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("creationDate")]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Статус, присвоенный начислению при создании квитанции
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("billStatus")]
        public AcknowledgmentStatusType BillStatus { get; set; }

        /// <summary>
        /// Разность между суммой, указанной в начислении, и суммой платежей с учетом возвратов
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("balance")]
        public long Balance { get; set; }

        [XmlIgnore]
        public bool BalanceSpecified { get; set; }

        /// <summary>
        /// УПНО, присвоенный участником, принявшим платеж
        /// <para>use: required</para>
        /// <para>type: com:PaymentIdType</para>
        /// </summary>
        [XmlAttribute("paymentId")]
        public string PaymentId { get; set; }

        /// <summary>
        /// Сумма, указанная в платеже
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("amountPayment")]
        public ulong AmountPayment { get; set; }

        [XmlIgnore]
        public bool AmountPaymentSpecified { get; set; }

        /// <summary>
        /// ИНН получателя средств
        /// <para>use: not required</para>
        /// <para>type: com:INNType</para>
        /// </summary>
        [XmlAttribute("payeeINN")]
        public string PayeeINN { get; set; }

        /// <summary>
        /// КПП получателя средств
        /// <para>use: not required</para>
        /// <para>type: com:KPPType</para>
        /// </summary>
        [XmlAttribute("payeeKPP")]
        public string PayeeKPP { get; set; }

        /// <summary>
        /// КБК
        /// <para>use: not required</para>
        /// <para>type: com:KBKType</para>
        /// </summary>
        [XmlAttribute("kbk")]
        public string Kbk { get; set; }

        /// <summary>
        /// Код ОКТМО
        /// <para>use: not required</para>
        /// <para>type: com:OKTMOType</para>
        /// </summary>
        [XmlAttribute("oktmo")]
        public string Oktmo { get; set; }

        /// <summary>
        /// Идентификатор плательщика
        /// <para>use: not required</para>
        /// <para>length: 1..22</para>
        /// </summary>
        [XmlAttribute("payerIdentifier")]
        public string PayerIdentifier { get; set; }

        /// <summary>
        /// Номер счета получателя средств
        /// <para>use: not required</para>
        /// <para>type: com:AccountNumType</para>
        /// </summary>
        [XmlAttribute("accountNumber")]
        public string AccountNumber { get; set; } //TODO type

        /// <summary>
        /// БИК структурного подразделения кредитной организации или подразделения Банка России, в котором открыт счет
        /// <para>use: not required</para>
        /// <para>type: com:BIKType</para>
        /// </summary>
        [XmlAttribute("bik")]
        public string Bik { get; set; } //TODO type

        /// <summary>
        /// Признак аннулирования квитанции
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("isRevoked")]
        public bool IsRevoked { get; set; }

        [XmlIgnore]
        public bool IsRevokedSpecified { get; set; }

        /// <summary>
        /// Признак уплаты с использованием ЕПГУ, РПГУ и иных порталов, интегрированных с ЕСИА
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("paymentPortal")]
        public bool PaymentPortal { get; set; }

        [XmlIgnore]
        public bool PaymentPortalSpecified { get; set; }

        /// <summary>
        /// Дополнительные условия оплаты
        /// <para>use: not required</para>
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
        /// Сведения о возврате денежных средств
        /// <para>use: not required</para>
        /// <para>occurs: 0..20</para>
        /// </summary>
        [XmlElement("Refund")]
        public Refund[] Refund { get; set; }  
    }
}
