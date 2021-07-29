using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
    public enum ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoServiceProvided
    {

        [XmlEnum("1")]
        Item1,

        [XmlEnum("2")]
        Item2,
    }
}
