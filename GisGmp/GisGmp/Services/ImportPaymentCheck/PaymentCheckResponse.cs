using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.ImportPaymentCheck
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-paymentcheck/2.4.0", IsNullable = false)]
    public class PaymentCheckResponse : ResponseType
    {
        public ImportProtocol ImportProtocol { get; set; }
    }
}
