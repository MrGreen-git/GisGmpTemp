using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.4.0")]
    public class PackageType
    {
        [XmlElement("ImportedChange", typeof(ImportedChangeType))]
        [XmlElement("ImportedCharge", typeof(ImportedChargeType))]
        [XmlElement("ImportedClarification", typeof(ImportedClarificationType))]
        [XmlElement("ImportedIncome", typeof(ImportedIncomeType))]
        [XmlElement("ImportedPayment", typeof(ImportedPaymentType))]
        [XmlElement("ImportedRefund", typeof(ImportedRefundType))]
        [XmlElement("ImportedRenouncement", typeof(ImportedRenouncementType))]
        public object[] Items { get; set; }
    }
}
