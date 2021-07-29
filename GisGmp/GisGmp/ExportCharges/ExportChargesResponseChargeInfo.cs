using GisGmp.Charge;
using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.ExportCharges
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.4.0")]
    public class ExportChargesResponseChargeInfo : ChargeType
    {
        [XmlElement("ReconcileWithoutPayment")]
        public ExportChargesResponseChargeInfoReconcileWithoutPayment[] ReconcileWithoutPayment { get; set; }

        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }

        [XmlAttribute]
        public long amountToPay { get; set; }

        [XmlAttribute]
        public AcknowledgmentStatusType acknowledgmentStatus { get; set; }

        [XmlIgnore]
        public bool acknowledgmentStatusSpecified { get; set; }

        [XmlAttribute]
        public string requisiteCheckCode { get; set; }
    }
}
