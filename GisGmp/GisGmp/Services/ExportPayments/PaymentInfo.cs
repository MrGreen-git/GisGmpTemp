using GisGmp.Common;
using GisGmp.Payment;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
    public class PaymentInfo : PaymentType
    {
        public AcknowledgmentInfo AcknowledgmentInfo { get; set; }

        [XmlElement("RefundInfo")]
        public RefundInfo[] RefundInfo { get; set; }

        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }
    }
}
