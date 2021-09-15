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

        public ChargeType(ChargeType charge) => Clone.Field(this, charge);

        /// <summary />
        public ChargeType(
            SupplierBillIDType supplierBillID,
            DateTime billDate, //
            ulong totalAmount, //
            string purpose, //
            KBKType kbk, //
            OKTMOType oktmo, //
            Payee payee, //
            ChargePayer payer, //
            BudgetIndexType budgetIndex //
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
        /// not required
        /// </summary>
        [XmlArrayItem("SupplierBillID", IsNullable = false)]
        public string[] LinkedChargesIdentifiers { get; set; }

        /// <summary>
        /// Данные организации, являющейся получателем средств. | required
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
        public Payee Payee { get; set; }

        /// <summary>
        /// Сведения о плательщике | required
        /// </summary>
        public ChargePayer Payer { get; set; }

        /// <summary>
        /// Реквизиты платежа 101, 106 - 109, предусмотренные Правилами указания информации в реквизитах распоряжений о переводе денежных средств в уплату платежей в бюджетную систему Российской Федерации (утверждены приказом Министерства финансов Российской Федерации от 12 ноября 2013 г. №107н)
        /// required
        /// </summary>
        public BudgetIndexType BudgetIndex { get; set; }

        /// <summary>
        /// Информация, необходимая для осуществления исполнительного производства | not required
        /// </summary>
        public ExecutiveProcedureInfoType ExecutiveProcedureInfo { get; set; }

        /// <summary>
        /// Дополнительная информация об административном правонарушении, зафиксированном с применением средств фото (видео) фиксации
        /// not required
        /// </summary>
        public OffenseType AdditionalOffense { get; set; }

        /// <summary>
        /// not required
        /// </summary>
        [XmlElement("DiscountFixed", typeof(DiscountFixed), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("DiscountSize", typeof(DiscountSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("MultiplierSize", typeof(MultiplierSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public DiscountType Item { get; set; }

        /// <summary>
        /// Поле номер 202: Дополнительные поля начисления | not required
        /// </summary>
        [XmlElement("AdditionalData", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public AdditionalDataType[] AdditionalData { get; set; }

        /// <summary>
        /// УИН | required
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }

        /// <summary>
        /// Поле номер 1011: Количество дней от даты начисления, подлежащей уплате плательщиком, по истечении которых необходимо повторно предоставлять уведомление о начислении по подписке в случае, если оно не оплачено или сумма платежей меньше суммы к оплате, указанной в начислении
        /// not required
        /// </summary>
        [XmlAttribute("noticeTerm", DataType = "integer")]
        public string NoticeTerm { get; set; }

        /// <summary>
        /// Код по ОКВЭД | not required
        /// </summary>
        [XmlAttribute("OKVED")]
        public string OKVED { get; set; }

        /// <summary>
        /// Поле номер 1400: Признак административного правонарушения, зафиксированного специальными техническими средствами, работающими в автоматическом режиме
        /// not required
        /// </summary>
        [XmlAttribute("chargeOffense", DataType = "integer")]
        public string ChargeOffense { get; set; }
    }
}
