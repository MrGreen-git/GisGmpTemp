using GisGmp.Common;
using GisGmp.Refund;
using System;
using System.Xml.Serialization;

namespace GisGmp.ExportRefunds
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.4.0")]
    public class ExportRefundsResponseRefund : RefundType
    {
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }
    }
}
