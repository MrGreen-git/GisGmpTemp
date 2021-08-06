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
        public ChargeType()
        {
            chargeOffense = "1";
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

        public Payer Payer { get; set; }

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

        [XmlElement("DiscountFixed", typeof(ChargeTypeDiscountDiscountFixed), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("DiscountSize", typeof(ChargeTypeDiscountDiscountSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("MultiplierSize", typeof(ChargeTypeDiscountMultiplierSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public DiscountType Item { get; set; }

        /// <summary>
        /// Поле номер 202: Дополнительные поля начисления
        /// </summary>
        [XmlElement("AdditionalData", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public AdditionalDataType[] AdditionalData { get; set; }

        /// <summary>
        /// УИН
        /// </summary>
        [XmlAttribute]
        public string supplierBillID { get; set; }

        [XmlAttribute]
        public DateTime billDate { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime validUntil { get; set; }

        [XmlIgnore]
        public bool validUntilSpecified { get; set; }

        [XmlAttribute]
        public ulong totalAmount { get; set; }

        [XmlAttribute]
        public string purpose { get; set; }

        [XmlAttribute]
        public string kbk { get; set; }

        [XmlAttribute]
        public string oktmo { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime deliveryDate { get; set; }

        [XmlIgnore]
        public bool deliveryDateSpecified { get; set; }

        [XmlAttribute]
        public string legalAct { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime paymentTerm { get; set; }

        [XmlIgnore]
        public bool paymentTermSpecified { get; set; }

        [XmlAttribute]
        public string origin { get; set; }

        [XmlAttribute(DataType = "integer")]
        public string noticeTerm { get; set; }

        [XmlAttribute]
        public string OKVED { get; set; }

        [XmlAttribute(DataType = "integer")]
        public string chargeOffense { get; set; }
    }
}
