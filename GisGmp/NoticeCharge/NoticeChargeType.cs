using GisGmp.Common;
using GisGmp.Organization;
using System;
using System.Xml.Serialization;

namespace GisGmp.NoticeCharge
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/NoticeCharge/2.4.0")]
    public class NoticeChargeType
    {
        public OrganizationType Payee { get; set; }

        public NoticeChargeTypePayer Payer { get; set; }

        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }

        [XmlElement("DiscountFixed", typeof(DiscountFixed), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("DiscountSize", typeof(DiscountSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("MultiplierSize", typeof(MultiplierSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public DiscountType Item { get; set; }

        public NoticeChargeTypeEventNotification EventNotification { get; set; }

        [XmlAttribute]
        public string supplierBillID { get; set; }

        [XmlAttribute]
        public DateTime billDate { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime validUntil { get; set; }

        [XmlIgnore]
        public bool validUntilSpecified { get; set; }

        [XmlAttribute(DataType = "date")]
        public DateTime paymentTerm { get; set; }

        [XmlIgnore]
        public bool paymentTermSpecified { get; set; }

        [XmlAttribute]
        public ulong totalAmount { get; set; }

        [XmlAttribute]
        public string purpose { get; set; }

        [XmlAttribute]
        public string kbk { get; set; }

        [XmlAttribute]
        public string oktmo { get; set; }

        [XmlAttribute(DataType = "integer")]
        public string chargeOffense { get; set; }

        [XmlAttribute]
        public long amountToPay { get; set; }

        [XmlAttribute]
        public AcknowledgmentStatusType acknowledgmentStatus { get; set; }

        [XmlIgnore]
        public bool acknowledgmentStatusSpecified { get; set; }
    }
}
