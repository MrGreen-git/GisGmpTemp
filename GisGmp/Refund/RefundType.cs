using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    [XmlInclude(typeof(ImportedRefundType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.4.0")]
    public class RefundType
    {
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.4.0")]
        public RefundPayer RefundPayer { get; set; }

        public RefundTypeRefundApplication RefundApplication { get; set; }

        public RefundTypeRefundBasis RefundBasis { get; set; }

        public RefundTypeRefundPayee RefundPayee { get; set; }

        [XmlElement("AdditionalData", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public AdditionalDataType[] AdditionalData { get; set; }

        [XmlAttribute]
        public string refundId { get; set; }

        [XmlAttribute]
        public DateTime refundDocDate { get; set; }

        [XmlAttribute]
        public RefundTypeBudgetLevel budgetLevel { get; set; }

        [XmlAttribute]
        public string kbk { get; set; }

        [XmlAttribute]
        public string oktmo { get; set; }
    }
}
