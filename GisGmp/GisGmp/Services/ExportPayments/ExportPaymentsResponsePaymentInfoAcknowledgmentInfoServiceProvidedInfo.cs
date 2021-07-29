using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
    public class ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfo
    {
        public ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoAdditionalRepaymenInfo AdditionalRepaymenInfo { get; set; }

        [XmlAttribute]
        public ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoServiceProvided serviceProvided { get; set; }
    }
}
