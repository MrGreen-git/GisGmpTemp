using GisGmp.Common;
using GisGmp.Organization;
using System;
using System.Xml.Serialization;

namespace GisGmp.NoticeCharge
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/NoticeCharge/2.4.0")]
    public class NoticeChargeExecutiveType
    {
        /// <summary>
        /// УИН
        /// <para>use: required</para>
        /// <para>type: com:SupplierBillIDType</para>
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }

        /// <summary>
        /// Дата и время начисления суммы денежных средств, подлежащих уплате
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("billDate")]
        public DateTime BillDate { get; set; }

        /// <summary>
        /// Дата, до которой (включительно) актуально выставленное начисление
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("validUntil", DataType = "date")]
        public DateTime ValidUntil { get; set; }

        [XmlIgnore]
        public bool ValidUntilSpecified { get; set; }

        /// <summary>
        /// Срок оплаты начисления в соответствии с нормативным правовым (правовым) актом
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("paymentTerm", DataType = "date")]
        public DateTime PaymentTerm { get; set; }

        [XmlIgnore]
        public bool PaymentTermSpecified { get; set; }

        /// <summary>
        /// Сумма начисления
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("totalAmount")]
        public ulong TotalAmount { get; set; }

        /// <summary>
        /// Назначение платежа
        /// <para>use: required</para>
        /// <para>length: 0..210</para>
        /// <para>pattern: "\S+([\S\s]*\S+)*"</para>
        /// </summary>
        [XmlAttribute("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// КБК
        /// <para>use: required</para>
        /// <para>type: com:KBKType</para>
        /// </summary>
        [XmlAttribute("kbk")]
        public string Kbk { get; set; }

        /// <summary>
        /// Код ОКТМО
        /// <para>use: required</para>
        /// <para>type: com:OKTMOType</para>
        /// </summary>
        [XmlAttribute]
        public string Oktmo { get; set; }

        /// <summary>
        /// Признак административного правонарушения, зафиксированного специальными техническими средствами, работающими в автоматическом режиме
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("chargeOffense", DataType = "integer")]
        public string ChargeOffense { get; set; }


        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
        public Payee Payee { get; set; }

        public NoticeChargeExecutiveTypePayer Payer { get; set; }

        public BudgetIndexType BudgetIndex { get; set; }

        public ExecutiveProcedureInfoType ExecutiveProcedureInfo { get; set; }

        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }

        [XmlElement("DiscountFixed", typeof(DiscountFixed), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("DiscountSize", typeof(DiscountSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("MultiplierSize", typeof(MultiplierSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public DiscountType Item { get; set; }

        

        

        

        

        

        

        

        

        

        [XmlAttribute]
        public long amountToPay { get; set; }

        [XmlAttribute]
        public AcknowledgmentStatusType acknowledgmentStatus { get; set; }

        [XmlIgnore]
        public bool acknowledgmentStatusSpecified { get; set; }
    }
}
