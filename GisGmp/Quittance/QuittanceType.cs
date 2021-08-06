using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Quittance
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Quittance/2.4.0")]
    public class QuittanceType
    {
        [XmlElement("DiscountFixed", typeof(DiscountFixed), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("DiscountSize", typeof(DiscountSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        [XmlElement("MultiplierSize", typeof(MultiplierSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public DiscountType Item { get; set; }

        [XmlElement("Refund")]
        public QuittanceTypeRefund[] Refund { get; set; }

        [XmlAttribute]
        public string supplierBillID { get; set; }

        [XmlAttribute]
        public ulong totalAmount { get; set; }

        [XmlIgnore]
        public bool totalAmountSpecified { get; set; }

        [XmlAttribute]
        public DateTime creationDate { get; set; }

        [XmlAttribute]
        public AcknowledgmentStatusType billStatus { get; set; }

        [XmlAttribute]
        public long balance { get; set; }

        [XmlIgnore]
        public bool balanceSpecified { get; set; }

        [XmlAttribute]
        public string paymentId { get; set; }

        [XmlAttribute]
        public ulong amountPayment { get; set; }

        [XmlIgnore]
        public bool amountPaymentSpecified { get; set; }

        [XmlAttribute]
        public string payeeINN { get; set; }

        [XmlAttribute]
        public string payeeKPP { get; set; }

        [XmlAttribute]
        public string kbk { get; set; }

        [XmlAttribute]
        public string oktmo { get; set; }

        [XmlAttribute]
        public string payerIdentifier { get; set; }

        [XmlAttribute]
        public string accountNumber { get; set; }

        [XmlAttribute]
        public string bik { get; set; }

        [XmlAttribute]
        public bool isRevoked { get; set; }

        [XmlIgnore]
        public bool isRevokedSpecified { get; set; }

        [XmlAttribute]
        public bool paymentPortal { get; set; }

        [XmlIgnore]
        public bool paymentPortalSpecified { get; set; }
    }
}
