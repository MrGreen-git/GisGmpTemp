using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Charge
{
    /// <summary>
    /// Данные нового начисления
    /// </summary>
    [XmlInclude(typeof(ImportedChargeType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0")]
    public class ChargeType : AbstractChargtType
    {
        /// <summary/>
        protected ChargeType() { }

        /// <summary />
        public ChargeType(
            SupplierBillIDType supplierBillID,
            DateTime billDate,
            ulong totalAmount,
            string purpose,
            KBKType kbk,
            OKTMOType oktmo,
            Payee payee,
            ChargePayer payer,
            BudgetIndexType budgetIndex
            )
        {
            SupplierBillID = supplierBillID;
            BillDate = billDate;
            TotalAmount = totalAmount;
            Purpose = purpose;
            Kbk = kbk;
            Oktmo = oktmo;
            Payee = payee;
            Payer = payer;
            BudgetIndex = budgetIndex;
        }

        /// <summary>
        /// Поле номер 1003: Идентификаторы начислений, на основании которых выставлено данное начисление
        /// </summary>
        [XmlArrayItem("SupplierBillID", IsNullable = false)]
        public string[] LinkedChargesIdentifiers { get; set; }

        /// <summary>
        /// Данные организации, являющейся получателем средств
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
        public Payee Payee { get; set; }

        public ChargePayer Payer { get; set; }

        /// <summary>
        /// Дополнительные реквизиты платежа, предусмотренные приказом Минфина России от 12 ноября 2013 г. №107н
        /// </summary>
        public BudgetIndexType BudgetIndex { get; set; }

        /// <summary>
        /// Дополнительная информация, необходимая для осуществления исполнительного производства
        /// </summary>
        public ExecutiveProcedureInfoType ExecutiveProcedureInfo { get; set; }

        /// <summary>
        /// Дополнительные условия оплаты
        /// </summary>
        public OffenseType AdditionalOffense { get; set; }

        [XmlElement("DiscountFixed", typeof(DiscountFixed), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("DiscountSize", typeof(DiscountSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("MultiplierSize", typeof(MultiplierSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public DiscountType Item { get; set; }

        /// <summary>
        /// Поле номер 202: Дополнительные поля начисления
        /// </summary>
        [XmlElement("AdditionalData", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public AdditionalDataType[] AdditionalData { get; set; }

        /// <summary>
        /// УИН
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }

        /// <summary>
        /// Поле номер 1011: Количество дней от даты начисления, подлежащей уплате плательщиком, по
        /// истечении которых необходимо повторно предоставлять уведомление о начислении по подписке в случае, если оно не
        /// оплачено или сумма платежей меньше суммы к оплате, указанной в начислении
        /// </summary>
        [XmlAttribute("noticeTerm", DataType = "integer")]
        public string NoticeTerm { get; set; }

        /// <summary>
        /// Код по ОКВЭД
        /// </summary>
        [XmlAttribute("OKVED")]
        public string OKVED { get; set; }

        /// <summary>
        /// Признак административного правонарушения, зафиксированного специальными техническими средствами, работающими в автоматическом режиме
        /// </summary>
        [XmlAttribute("chargeOffense", DataType = "integer")]
        public string ChargeOffense { get; set; }
    }
}
