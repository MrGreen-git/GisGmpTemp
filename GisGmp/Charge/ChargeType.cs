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
        protected ChargeType() { }

        public ChargeType(ChargeType charge) => Clone.Field(this, charge);

        /// <summary>
        /// Данные нового начисления
        /// </summary>
        /// <param name="supplierBillID">УИН</param>
        /// <param name="billDate">Поле номер 4: Дата, а также сведения о периоде времени, в который осуществлено начисление суммы денежных средств, подлежащих уплате(до 21 часа или после 21 часа по местному времени), либо время начисления суммы денежных средств, подлежащих уплате</param>
        /// <param name="totalAmount">Поле номер 7: Сумма начисления</param>
        /// <param name="purpose">Поле номер 24: Назначение платежа</param>
        /// <param name="kbk">Поле номер 104: КБК</param>
        /// <param name="oktmo">Поле номер 105: Код ОКТМО</param>
        /// <param name="payee">Данные организации, являющейся получателем средств</param>
        /// <param name="payer">Сведения о плательщике</param>
        /// <param name="budgetIndex">Реквизиты платежа 101, 106 - 109, предусмотренные Правилами указания информации в реквизитах распоряжений о переводе денежных средств в уплату платежей в бюджетную систему Российской Федерации (утверждены приказом Министерства финансов Российской Федерации от 12 ноября 2013 г. №107н)</param>
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
        /// <para>use: not required</para>
        /// <para>occurs: 0..10</para>
        /// </summary>
        [XmlArrayItem("SupplierBillID", IsNullable = false)]
        public string[] LinkedChargesIdentifiers { get; set; } //TODO type

        /// <summary>
        /// Данные организации, являющейся получателем средств
        /// <para>use: required</para>
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
        public Payee Payee { get; set; }

        /// <summary>
        /// Сведения о плательщике
        /// <para>use: required</para>
        /// </summary>
        public ChargePayer Payer { get; set; }

        /// <summary>
        /// Реквизиты платежа 101, 106 - 109, предусмотренные Правилами указания информации в реквизитах распоряжений о переводе денежных средств в уплату платежей в бюджетную систему Российской Федерации (утверждены приказом Министерства финансов Российской Федерации от 12 ноября 2013 г. №107н)
        /// <para>use: required</para>
        /// </summary>
        public BudgetIndexType BudgetIndex { get; set; }

        /// <summary>
        /// Информация, необходимая для осуществления исполнительного производства
        /// <para>use: not required</para>
        /// </summary>
        public ExecutiveProcedureInfoType ExecutiveProcedureInfo { get; set; }

        /// <summary>
        /// Дополнительная информация об административном правонарушении, зафиксированном с применением средств фото (видео) фиксации
        /// <para>use: not required</para>
        /// </summary>
        public OffenseType AdditionalOffense { get; set; }

        /// <summary>
        /// <para>use: not required</para>
        /// </summary>
        [XmlElement("DiscountFixed", typeof(DiscountFixed), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("DiscountSize", typeof(DiscountSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("MultiplierSize", typeof(MultiplierSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public DiscountType Item { get; set; } //TODO property

        /// <summary>
        /// Поле номер 202: Дополнительные поля начисления | not required
        /// <para>use: not required</para>
        /// <para>occurs: 0..10</para>
        /// </summary>
        [XmlElement("AdditionalData", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public AdditionalDataType[] AdditionalData { get; set; }

        /// <summary>
        /// УИН
        /// <para>use: required</para>
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; } //TODO изменить тип

        /// <summary>
        /// Поле номер 1011: Количество дней от даты начисления, подлежащей уплате плательщиком, по истечении которых необходимо повторно предоставлять уведомление о начислении по подписке в случае, если оно не оплачено или сумма платежей меньше суммы к оплате, указанной в начислении
        /// <para>use: not required</para>
        /// <para>value: 1..max</para>
        /// </summary>
        [XmlAttribute("noticeTerm", DataType = "integer")]
        public string NoticeTerm { get; set; }

        /// <summary>
        /// Код по ОКВЭД
        /// <para>use: not required</para>
        /// </summary>
        [XmlAttribute("OKVED")]
        public string OKVED { get; set; } //TODO type

        /// <summary>
        /// Поле номер 1400: Признак административного правонарушения, зафиксированного специальными техническими средствами, работающими в автоматическом режиме
        /// <para>use: not required</para>
        /// <para>value: 1</para>
        /// </summary>
        [XmlAttribute("chargeOffense", DataType = "integer")]
        public string ChargeOffense { get; set; }
    }
}
