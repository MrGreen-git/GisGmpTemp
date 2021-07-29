using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0", IsNullable = false)]
    public class ExportPaymentsResponse : ResponseType
    {
        [XmlElement("PaymentInfo")]
        public ExportPaymentsResponsePaymentInfo[] PaymentInfo { get; set; }

        [XmlAttribute]
        public bool hasMore { get; set; }
    }
}
