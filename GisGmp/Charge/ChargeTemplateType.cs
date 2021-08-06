using GisGmp.Common;
using GisGmp.Organization;
using System;
using System.Xml.Serialization;

namespace GisGmp.Charge
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.4.0")]
    public class ChargeTemplateType : AbstractChargtType
    {
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
        public Payee Payee { get; set; }

        public Payer Payer { get; set; }

        public BudgetIndexType BudgetIndex { get; set; }

        [XmlElement("DiscountFixed", typeof(DiscountFixed), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("DiscountSize", typeof(DiscountSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("MultiplierSize", typeof(MultiplierSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
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
    }
}
