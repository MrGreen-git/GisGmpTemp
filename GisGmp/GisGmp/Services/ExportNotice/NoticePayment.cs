using GisGmp.Common;
using GisGmp.Payment;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNotice
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.4.0")]
    public class NoticePayment : PaymentType
    {
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.4.0")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }
    }
}
