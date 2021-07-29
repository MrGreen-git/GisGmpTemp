using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.4.0")]
    public class ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoAdditionalRepaymenInfo
    {
        [XmlElement("ServiceData")]
        public ExportPaymentsResponsePaymentInfoAcknowledgmentInfoServiceProvidedInfoAdditionalRepaymenInfoServiceData[] ServiceData { get; set; }

        [XmlAttribute]
        public long residualAmount { get; set; }
    }
}
