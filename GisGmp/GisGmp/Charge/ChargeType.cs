﻿using GisGmp.Common;
using GisGmp.Organization;
using System;
using System.Xml.Serialization;

namespace GisGmp.Charge
{
    [XmlInclude(typeof(ImportedChargeType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0")]
    public class ChargeType : AbstractChargtType
{
public ChargeType()
        {
            chargeOffense = "1";
        }

        [XmlArrayItem("SupplierBillID", IsNullable = false)]
        public string[] LinkedChargesIdentifiers { get; set; }

        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
        public Payee Payee { get; set; }

        public Payer Payer { get; set; }

        public BudgetIndexType BudgetIndex { get; set; }

        public ExecutiveProcedureInfoType ExecutiveProcedureInfo { get; set; }

        public OffenseType AdditionalOffense { get; set; }

        [XmlElement("DiscountFixed", typeof(ChargeTypeDiscountDiscountFixed), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("DiscountSize", typeof(ChargeTypeDiscountDiscountSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("MultiplierSize", typeof(ChargeTypeDiscountMultiplierSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public DiscountType Item { get; set; }

        [XmlElement("AdditionalData", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public AdditionalDataType[] AdditionalData { get; set; }

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
